using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HelloEnglishTeacher
{
    public partial class MainForm : Form
    {
        // MainForm 마우스 드래그 이동 변수
        private bool m_isMouseDown = false;
        private int m_title_dx = 0;
        private int m_title_dy = 0;

        private string APP_PATH = System.Windows.Forms.Application.StartupPath;
        private string newfileName;
        private ProcessForm processForm;
        private Dictionary<string, string> config = new Dictionary<string, string>();


        public MainForm()
        {
            InitializeComponent();
        }

        #region Form Load/Close
        // Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                label1.ForeColor = Color.LightBlue;
                // 환경설정 파일 읽어오기
                ReadConfigFile();
                // 최근 파일 경로 설정 
                string recentFilePath = config[MsgCode.KEY_FILE_NAME_RECENT];
                if (recentFilePath.Equals("") || recentFilePath == null)
                    recentFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  //바탕화면 경로

                // OpenFile 최근 경로 설정
                OpenFile.InitialDirectory = recentFilePath;

                // 시험 유형 초기화
                comboBoxExamType.Items.Add(MsgCode.KEY_EXAM_TYPE_WORD);
                comboBoxExamType.Items.Add(MsgCode.KEY_EXAM_TYPE_MEAN);
                comboBoxExamType.Items.Add(MsgCode.KEY_EXAM_TYPE_SYNO);
                comboBoxExamType.SelectedIndex = 0;

                comboBoxExamType2.Items.Add(MsgCode.KEY_EXAM_TYPE_WORD_TO_MEAN);
                comboBoxExamType2.Items.Add(MsgCode.KEY_EXAM_TYPE_MEAN_TO_WORD);
                comboBoxExamType2.Items.Add(MsgCode.KEY_EXAM_TYPE_SELECT_SYNO);
                comboBoxExamType2.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                CallMsgForm(MsgCode.MSG_ASK_DEV + err.Message);
                this.Close();
                Environment.Exit(0);
            }
        }

        // Form Close
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteConfigFile();  //Config 파일에 쓰기
        }
        #endregion

        // Open 버튼 Click Event
        private void btnFileSearch_Click(object sender, EventArgs e)
        {
            txtFilePath.Text = "";                      //Init the file Path
            List<string> list = new List<string>();     //Excel의 단어 목록 담고 있는 List

            // Check-01 : 문제 만든다고 했는데 문제가 개수가 0인지 체크
            if (!CheckExamRange())
            {
                // 문제 낸다고 했는데 개수가 0개 일 때
                FailToCheck(MsgCode.MSG_EXAM_WRONG_NUM);
            }
            else
            {
                DialogResult dr = OpenFile.ShowDialog();    //파일 탐색기 객체 열기

                // Check-02 : 파일 탐색기 "확인" 버튼 체크
                if (dr != DialogResult.OK)
                {
                    //파일 탐색기에서 취소 누르거나 파일 선택하지 않고 나왔을 때
                    FailToCheck(MsgCode.MSG_SELECT_FILE);
                }
                else
                {
                    string fileFullPath = OpenFile.FileName;    //선택한 파일 전체 경로
                    string fileName = OpenFile.SafeFileName;    //선택한 파일 이름
                    string filePath = fileFullPath.Substring(0, (fileFullPath.Length - fileName.Length)); // 선택한 파일 경로

                    // Check-03 : 파일 확장자 체크
                    if (!CheckFileExtension(fileFullPath))
                    {
                        //파일 확장자 잘못 됐을 때
                        FailToCheck(MsgCode.MSG_NO_MATCH_EXTENSION);
                    }
                    else
                    {
                        //엑셀 파일 읽기
                        list = ReadWordFromExcel(fileFullPath, filePath, fileName);

                        // Check-04 : 엑셀 파일에 단어 개수 체크
                        if (list.Count <= 0)
                        {
                            //엑셀에 단어가 없을 때
                            EndProcessing();
                            FailToCheck(MsgCode.MSG_NO_WORD_IN_FILE);
                        }
                        else
                        {
                            //네이버 사전에서 단어 검색
                            Dictionary<String, List<List<string>>> result = SearchWord(fileFullPath, list);

                            //엑셀에 결과 쓰기
                            WriteWordFromExcel(fileFullPath, filePath, fileName, list, result);

                            // Check-05 : 시험 문제 출제하는데 단어 수보다 문제 수가 더 많은지 체크
                            if (chkMakeExam.Checked == true && list.Count < Int32.Parse(txtExamNum.Text))
                            {
                                // 파일에 있는 단어 수보다 문제 수가 더 많을 때
                                CallMsgForm(MsgCode.MSG_EXAM_WRONG_RANGE);
                                EndProcessing();
                                picCheck1.Visible = true;
                                label1.Visible = true;
                                System.Diagnostics.Process.Start(filePath);
                            }
                            else
                            {
                                //시험문제 만들기
                                MakeExam(fileFullPath, filePath, fileName, list.Count);

                                //End Processing
                                EndProcessing();
                                picCheck1.Visible = true;
                                label1.Visible = true;
                                System.Diagnostics.Process.Start(filePath);
                            }
                        }
                    }
                }
            }
        }

        /**
         * '시험 만들기' 체크 박스가 Checked 일 때 시험 범위 및 개수 검증
         */
        private bool CheckExamRange()
        {
            if (chkMakeExam.Checked == true)
            {
                int examNum = txtExamNum.Text.Equals("") ? 0 : Int32.Parse(txtExamNum.Text);

                if (examNum == 0)
                    return false;
            }
            return true;
        }

        /**
         * 입력 받은 파일 확장자 체크
         * @Param string fileFullPath
         *   - 입력받은 파일의 전체 경로 (파일 경로 + 파일 이름 + 확장자)
         * @Return bool
         */
        private bool CheckFileExtension(string fileFullPath)
        {
            string ext = Path.GetExtension(fileFullPath);

            if (ext.Equals(".xlsx") || ext.Equals(".csv") || ext.Equals(".xls"))
                return true;
            else
                return false;
        }
        /**
         * Excel 파일 안에 단어 읽기
         * @Param string fileFullPath
         *   - 입력받은 파일의 전체 경로 (파일 경로 + 파일 이름 + 확장자)
         * @Param string filePath
         *   - 입력받은 파일의 경로 (파일 경로)
         * @Param string fileName
         *   - 입력받은 파일의 이름 (파일 이름 + 확장자)
         * @Return List list
         *   - 파일 안에 있는 단어 전체를 담고 있는 List ( A열 )
         */
        private List<string> ReadWordFromExcel(string fileFullPath, string filePath, string fileName)
        {
            //파일이 열려있는지 확인
            while (!FileIO.IsFileOpen(fileFullPath))
            {
                CallMsgForm(MsgCode.MSG_FILE_ALREADY_OPENED);
            }

            List<string> list = new List<string>();
            if (MessageBox.Show(MsgCode.MSG_PROCESSING, MsgCode.MSG_PROCESSING_HEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // Config에 파일 전체 경로 저장
                if (!filePath.Equals("")) config[MsgCode.KEY_FILE_NAME_RECENT] = filePath;
                //텍스트 박스에 파일 경로 노출
                txtFilePath.Text = fileName;

                // Processing 시작
                StartProcessing();

                //안내 문구 설정(파일 읽는 중)
                label1.Text = MsgCode.MSG_READING_FILE;
                label1.Visible = true;

                // 파일 OPEN 및 READ
                this.Cursor = Cursors.WaitCursor;
                WorkBook wb = new WorkBook(fileFullPath, filePath, fileName);
                list = wb.ReadExcel();
                this.Cursor = Cursors.Default;

                //안내 문구 설정(파일 읽기 완료)
                label1.Text = MsgCode.MSG_READING_FILE_DONE;
            }
            else
            {
                FailToCheck(MsgCode.MSG_SELECT_FILE_AGAIN);
            }
            return list;
        }

        /**
         * 단어를 네이버 사전에서 검색
         * @Param string fileFullPath
         *   - 입력받은 파일의 전체 경로 (파일 경로 + 파일 이름 + 확장자)
         * @Param List list
         *   - 파일 안에 있는 단어 전체를 담고 있는 List ( A열 )
         * @Return Dictionary 
         *   - 검색 결과를 담고 있는 Dictionary
         */
        private Dictionary<String, List<List<string>>> SearchWord(string fileFullPath, List<string> list)
        {
            //파일이 열려있는지 확인
            while (!FileIO.IsFileOpen(fileFullPath))
            {
                CallMsgForm(MsgCode.MSG_FILE_ALREADY_OPENED);
            }

            //안내 문구 설정(n개 사전 검색 중)
            label1.Text = MsgCode.MSG_SEARCHING_NAVER_DIC_START + list.Count + MsgCode.MSG_SEARCHING_NAVER_DIC_END;

            // 네이버 사전 검색
            this.Cursor = Cursors.WaitCursor;
            Selenium selenium = new Selenium();
            Dictionary<String, List<List<string>>> result = selenium.SearchEng(list);
            this.Cursor = Cursors.Default;

            //안내 문구 설정(사전 검색 끝)
            label1.Text = MsgCode.MSG_SEARCHING_NAVER_DIC_DONE;

            return result;
        }

        /**
         * 검색 결과를 Excel 파일에 쓰기
         * @Param string fileFullPath
         *   - 입력받은 파일의 전체 경로 (파일 경로 + 파일 이름 + 확장자)
         * @Param string filePath
         *   - 입력받은 파일의 경로 (파일 경로)
         * @Param string fileName
         *   - 입력받은 파일의 이름 (파일 이름 + 확장자)
         * @Param List list
         *   - 파일 안에 있는 단어 전체를 담고 있는 List ( A열 )
         * @Param Dictionary result
         *   - 검색 결과를 담고 있는 Dictionary
         */
        private void WriteWordFromExcel(string fileFullPath, string filePath, string fileName, List<string> list, Dictionary<String, List<List<string>>> result)
        {
            //안내 문구 설정 (파일에 검색 결과 쓰기)
            label1.Text = MsgCode.MSG_FILE_WRITING_RESULT;

            // 결과 Write
            this.Cursor = Cursors.WaitCursor;
            WorkBook wb = new WorkBook(fileFullPath, filePath, fileName);
            newfileName = wb.WriteExcel(list, result);
            this.Cursor = Cursors.Default;

            // 안내 문구 설정 (파일에 검색 결과 쓰기 완료)
            label1.Text = MsgCode.MSG_FILE_WRITING_RESULT_DONE;
        }

        /**
         * 시험 문제 만들고 쓰기 
         * @Param string fileFullPath
         *   - 입력받은 파일의 전체 경로 (파일 경로 + 파일 이름 + 확장자)
         * @Param string filePath
         *   - 입력받은 파일의 경로 (파일 경로)
         * @Param string fileName
         *   - 입력받은 파일의 이름 (파일 이름 + 확장자)
         */
        private void MakeExam(string fileFullPath, string filePath, string fileName, int wordCnt)
        {
            string examType = comboBoxExamType.SelectedItem.ToString();
            int examNum = txtExamNum.Text.Equals("") ? 0 : Int32.Parse(txtExamNum.Text);
            bool showFirstWord = chkBoxFirstWord.Checked;

            // 안내 문구 설정 (문제 선택하는 중)
            label1.Text = MsgCode.MSG_EXAM_CHOOSE;

            this.Cursor = Cursors.WaitCursor;
            WorkBook wb = new WorkBook(newfileName, filePath, fileName);
            //List<List<string>> examList = wb.MakeExam(examStart, examEnd, examNum);
            wb.MakeExam(examType, wordCnt, examNum, showFirstWord);
            this.Cursor = Cursors.Default;

            // 안내 문구 설정 (파일 완성 !)
            label1.ForeColor = Color.Red;
            label1.Text = MsgCode.MSG_FINAL;
        }

        #region Config Read/Write
        private void ReadConfigFile()
        {
            FileIO file = new FileIO(MsgCode.KEY_FILE_IO_READ, APP_PATH + "/" + MsgCode.KEY_FILE_NAME_CONFIG);
            config = file.ReadConfigFile();
        }

        private void WriteConfigFile()
        {
            FileIO file = new FileIO(MsgCode.KEY_FILE_IO_WRITE, APP_PATH + "/" + MsgCode.KEY_FILE_NAME_CONFIG);
            file.WriteConfig(config);
        }
        #endregion

        #region 기타함수
        private void StartProcessing()
        {
            // Processing 보이기
            Worker.RunWorkerAsync();

            //Checkbox 숨기기
            picCheck1.Visible = false;

            // 시험 유형 숨기기
            chkMakeExam.Visible = false;
            labelMakeExam.Visible = false;
            panelExam.Visible = false;
        }

        private void EndProcessing()
        {
            // 시험 유형 보이기
            chkMakeExam.Visible = true;
            labelMakeExam.Visible = true;
            panelExam.Visible = true;

            // Processing 숨기기
            CheckForIllegalCrossThreadCalls = false;
            processForm.Close();
        }

        private void FailToCheck(String message)
        {
            txtFilePath.Text = "";
            label1.Visible = false;
            picCheck1.Visible = false;
            CallMsgForm(message);
        }
        #endregion

        #region Form Event
        // Form 종료 (Alt + F4)
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Alt | Keys.F4))
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        // Form 종료 (X 버튼)
        private void picXbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        // 마우스 드래그 함수
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            m_isMouseDown = true;
            m_title_dx = e.X;
            m_title_dy = e.Y;
        }

        // 마우스 드래그 함수
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_isMouseDown)
            {
                this.Left = Control.MousePosition.X - m_title_dx;
                this.Top = Control.MousePosition.Y - m_title_dy;
            }
        }

        // 마우스 드래그 함수
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            m_isMouseDown = false;
        }

        //숫자만 입력받기
        private void txtExamStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }

        //숫자만 입력받기
        private void txtExamEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }

        //숫자만 입력받기
        private void txtExamNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8) //8:백스페이스,45:마이너스,46:소수점
            {
                e.Handled = true;
            }
        }

        //Exam End Text Changed
        private void txtExamEnd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int examStart = txtExamStart.Text.Equals("") ? 0 : Int32.Parse(txtExamStart.Text);
                int examEnd = txtExamEnd.Text.Equals("") ? 0 : Int32.Parse(txtExamEnd.Text);
                txtExamNum.Text = (examEnd - examStart + 1).ToString();
            }
            catch (Exception) { }
        }

        //Exam Start Text Changed
        private void txtExamStart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int examStart = txtExamStart.Text.Equals("") ? 0 : Int32.Parse(txtExamStart.Text);
                int examEnd = txtExamEnd.Text.Equals("") ? 0 : Int32.Parse(txtExamEnd.Text);
                txtExamNum.Text = (examEnd - examStart + 1).ToString();
            }
            catch (Exception) { }
        }

        //Exam Label Click
        private void labelMakeExam_Click(object sender, EventArgs e)
        {
            if (chkMakeExam.Checked == true)
            {
                chkMakeExam.Checked = false;
            }
            else
            {
                chkMakeExam.Checked = true;
            }
        }

        //Exam Checkbox Changed
        private void chkMakeExam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMakeExam.Checked == true)
            {
                panelExam.Enabled = true;
            }
            else
            {
                panelExam.Enabled = false;
            }
        }

        private void picContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact & 버그 & 추가 기능 :)\npure_yong@naver.com", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        public void CallMsgForm(string msg)
        {
            MsgForm msgForm = new MsgForm(msg);
            msgForm.ShowDialog();
        }

        private void comboBoxExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExamType.SelectedItem.ToString().Equals(MsgCode.KEY_EXAM_TYPE_SYNO))
            {
                LabelFirstWord.Enabled = true;
                chkBoxFirstWord.Enabled = true;
            }
            else
            {
                LabelFirstWord.Enabled = false;
                chkBoxFirstWord.Enabled = false;
                chkBoxFirstWord.Checked = false;
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            processForm = new ProcessForm(this.Location.X, this.Location.Y, this.Width, this.Height);
            processForm.ShowDialog();
        }
    }
}
