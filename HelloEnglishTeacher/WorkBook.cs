using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;



namespace HelloEnglishTeacher
{
    class WorkBook
    {
        private Excel.Application excel = null;
        private Excel.Workbook wb = null;
        private Excel.Worksheet ws = null;

        private string fullFilepath; 
        private string filePath;
        private string fileName;

        public WorkBook(string fullFilepath, string filePath, string fileName)
        {
            excel = new Excel.Application();
            wb = excel.Workbooks.Open(fullFilepath);
            excel.DisplayAlerts = false;
            this.fullFilepath = fullFilepath;
            this.filePath = filePath;
            this.fileName = fileName;
        }
        
        public List<string> ReadExcel()
        {
            List<string> list = new List<string>();
            try
            {
                //ws = wb.Worksheets["Sheet1"];
                ws = excel.Application.ActiveWorkbook.Sheets[1];

                for (int i = 2; i < 5000; i++)
                { 
                    string value = (ws.Cells[i, 1] as Range).Value;
                    if (value == null)
                        break;
                    else
                    {
                        list.Add(value);
                    }
                }
            }
            catch (Exception err) 
            {
                CallMsgForm(err.Message);
                this.Close();
            }
            finally
            {
                this.Close();
            }

            return list;
        }

        public string WriteExcel(List<string> list, Dictionary<String, List<List<string>>> result)
        {
            string newfileName = "";
            try
            {
                //ws = wb.Worksheets["Sheet1"];
                ws = excel.Application.ActiveWorkbook.Sheets[1];
                for (int i= 0; i < list.Count; i++)
                {
                    //뜻 채우기
                    int cells = 2;
                    for (int j = 0; j < result[list[i]][0].Count; j++)
                    {
                        if (j == 3)
                            break;
                        ws.Cells[cells++][i + 2] = result[list[i]][0][j];
                    }

                    //유의어 채우기
                    cells = 5;
                    for (int j = 0; j < result[list[i]][1].Count; j++)
                    {
                        if (j == 3)
                            break;
                        ws.Cells[cells++][i + 2] = result[list[i]][1][j];
                    }

                    //반의어 채우기
                    cells = 8;
                    for (int j = 0; j < result[list[i]][2].Count; j++)
                    {
                        if (j == 3)
                            break;
                        ws.Cells[cells++][i + 2] = result[list[i]][2][j];
                    }

                    //영영풀의 채우기
                    cells = 11;
                    for (int j = 0; j < result[list[i]][3].Count; j++)
                    {
                        if (j == 3)
                            break;
                        ws.Cells[cells++][i + 2] = result[list[i]][3][j];
                    }
                }

                //모든 Cell 높이 설정
                ws.Rows.RowHeight = 18;

                // 새로운 이름으로 파일 쓰기
                newfileName = filePath + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + fileName;
                wb.SaveAs(newfileName);
            }
            catch (Exception err)
            {
                CallMsgForm(err.Message);
                this.Close();
            }
            finally
            {
                this.Close();
            }
            return newfileName;
        }

        //public List<List<string>> MakeExam(int examStart, int examEnd, int examNum)
        public void MakeExam(string examType, int wordCnt, int examNum, Boolean showFirstWord)
        {
            try
            {
                //시험 문제 선택
                List<List<string>> result = this.SelectExam(wordCnt, examNum);

                //시험 문제 쓰기
                this.WriteExam(examType, result, showFirstWord);
            }
            catch (Exception err)
            {
                CallMsgForm(err.Message);
                this.Close();
            }
            finally
            {
                this.Close();
            }
        }

        private List<List<string>> SelectExam(int wordCnt, int examNum)
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                ws = excel.Application.ActiveWorkbook.Sheets[1];
                Random random = new Random();

                int[] selected = new int[wordCnt + 2];
                int rowNo = 0;
                int examCnt = 0;

                while (examNum > examCnt)
                {
                    //랜덤숫자 생성 (범위 : 2행 ~ 마지막행)
                    //이미 선택한 문제면 Continue;
                    if (selected[rowNo = random.Next(2, wordCnt + 2)] == 1)
                        continue;
                    
                    string word = (ws.Cells[rowNo, 1] as Range).Value;  // A  단어
                    string mean = (ws.Cells[rowNo, 2] as Range).Value;  // B  뜻1
                    string sync1 = (ws.Cells[rowNo, 5] as Range).Value; // E  유의어1
                    string sync2 = (ws.Cells[rowNo, 6] as Range).Value; // F  유의어2

                    result.Add(new List<string>());
                    result[examCnt].Add(word);
                    result[examCnt].Add(mean);
                    result[examCnt].Add(sync1);
                    result[examCnt].Add(sync2);

                    selected[rowNo] = 1;    //선택한 Row 표시
                    examCnt++;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.ToString());
            }
            return result;
        }

        private void WriteExam(string examType, List<List<string>> examList, bool showFirstWord)
        {
            try
            {
                ws = excel.Application.ActiveWorkbook.Sheets[2];

                switch (examType)
                {
                    //단어쓰기
                    case MsgCode.KEY_EXAM_TYPE_WORD:  
                        for (int i = 0; i < examList.Count; i++)
                        {
                            // 2행부터 쓰기 (i+2)
                            //ws.Cells[i + 2, 1] = examList[i][0]; // A 단어
                            ws.Cells[i + 2, 2] = examList[i][1]; // B 뜻
                            ws.Cells[i + 2, 3] = examList[i][2]; // C 유의어1
                            ws.Cells[i + 2, 4] = examList[i][3]; // D 유의어2
                            ws.Cells[i + 2, 5] = examList[i][0]; // E 정답
                        }
                        break;

                    //뜻쓰기
                    case MsgCode.KEY_EXAM_TYPE_MEAN:
                        for (int i = 0; i < examList.Count; i++)
                        {
                            // 2행부터 쓰기 (i+2)
                            ws.Cells[i + 2, 1] = examList[i][0]; // A 단어
                            //ws.Cells[i + 2, 2] = examList[i][1]; // B 뜻
                            ws.Cells[i + 2, 3] = examList[i][2]; // C 유의어1
                            ws.Cells[i + 2, 4] = examList[i][3]; // D 유의어2
                            ws.Cells[i + 2, 5] = examList[i][1]; // E 정답
                        }
                        break;
                    //유의어 쓰기
                    case MsgCode.KEY_EXAM_TYPE_SYNO:
                        //첫글자 보여주기
                        if (showFirstWord)
                        {
                            for (int i = 0; i < examList.Count; i++)
                            {
                                // 2행부터 쓰기 (i+2)
                                ws.Cells[i + 2, 1] = examList[i][0]; // A 단어
                                ws.Cells[i + 2, 2] = examList[i][1]; // B 뜻
                                ws.Cells[i + 2, 3] = examList[i][2].Substring(0, 1); // C 유의어1
                                ws.Cells[i + 2, 4] = examList[i][3].Substring(0, 1); // D 유의어2                                                                     
                                ws.Cells[i + 2, 5] = examList[i][2]; // E 정답
                                ws.Cells[i + 2, 6] = examList[i][3]; // F 정답
                            }
                        }
                        //첫글자 안보여주기
                        else
                        {
                            for (int i = 0; i < examList.Count; i++)
                            {
                                // 2행부터 쓰기 (i+2)
                                ws.Cells[i + 2, 1] = examList[i][0]; // A 단어
                                ws.Cells[i + 2, 2] = examList[i][1]; // B 뜻
                                ws.Cells[i + 2, 3] = " "; // C 유의어1
                                ws.Cells[i + 2, 4] = " "; // D 유의어2
                                ws.Cells[i + 2, 5] = examList[i][2]; // E 정답
                                ws.Cells[i + 2, 6] = examList[i][3]; // F 정답
                            }
                        }
                        break;
                }

                //모든 Cell 높이 설정
                ws.Rows.RowHeight = 18;

                // 새로운 이름으로 파일 쓰기
                wb.Save();
            }
            catch(Exception err)
            {
                throw new Exception(err.ToString());
            }
        }
        private void Close()
        {
            if (wb != null) { wb.Close(); wb = null; }
            if (ws != null) { ws = null; }
            if (excel != null) { excel.Quit(); excel = null; }
        }

        public void CallMsgForm(string msg)
        {
            MsgForm msgForm = new MsgForm(MsgCode.MSG_ASK_DEV + msg);
            msgForm.ShowDialog();
        }
    }
}
