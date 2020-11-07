using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloEnglishTeacher
{
    class MsgCode
    {
        public const string KEY_FILE_IO_READ = "READ";
        public const string KEY_FILE_IO_WRITE = "WRITE";

        public const string KEY_FILE_NAME_CONFIG = "properties";
        public const string KEY_FILE_NAME_RECENT = "RECENT_PATH";

        public const string KEY_EXAM_TYPE_WORD = "단어쓰기";
        public const string KEY_EXAM_TYPE_MEAN = "뜻쓰기";
        public const string KEY_EXAM_TYPE_SYNO = "유의어쓰기";

        public const string KEY_EXAM_TYPE_WORD_TO_MEAN = "단어보고 뜻 고르기";
        public const string KEY_EXAM_TYPE_MEAN_TO_WORD = "뜻보고 단어 고르기";
        public const string KEY_EXAM_TYPE_SELECT_SYNO = "동의어 모두 고르기";

        public const string MSG_ASK_DEV = "프로그램 개발자에게 문의하세요.\n";

        public const string MSG_NO_WORD_IN_FILE = "단어가 없습니다. 파일을 다시 선택해주세요.";
        public const string MSG_NO_MATCH_EXTENSION = ".xlsx, .csv 파일을 다시 선택해주세요 !";
        public const string MSG_EXAM_WRONG_NUM = "문제 개수를 입력해주세요.";
        public const string MSG_EXAM_WRONG_RANGE = "[ 문제 생성 실패 ]\n입력하신 문제 수가 단어 수보다 많습니다.";
        public const string MSG_EXAM_WRONG_RANGE_FILE = "문제 범위 오류로 문제를 만들지 못했습니다.";

        public const string MSG_SELECT_FILE = "파일을 선택해주세요 !";
        public const string MSG_SELECT_FILE_AGAIN = "파일을 다시 선택해주세요 !";
        
        public const string MSG_FILE_ALREADY_OPENED = "파일이 열려있습니다. 파일을 닫은 후 확인 버튼을 눌러주세요.";
        public const string MSG_FILE_ALREADY_OPENED_HEADER = "File is already opened";

        public const string MSG_READING_FILE = "파일 읽는 중 !";
        public const string MSG_READING_FILE_DONE = "파일 읽기 완료 !";

        public const string MSG_SEARCHING_NAVER_DIC_START = "입력 받은 단어 ";
        public const string MSG_SEARCHING_NAVER_DIC_END = "개 검색 중 !";
        public const string MSG_SEARCHING_NAVER_DIC_DONE = "네이버 사전 검색 완료 !";
        
        public const string MSG_FILE_WRITING_RESULT = "파일에 검색 결과 쓰는 중 !";
        public const string MSG_FILE_WRITING_RESULT_DONE = "파일에 검색 결과 쓰기 완료 !";

        public const string MSG_EXAM_CHOOSE = "문제 만드는 중 !";
        public const string MSG_EXAM_WRITING_EXAM = "선택한 문제 쓰는 중 !";
        public const string MSG_FINAL = "파일을 완성했습니다 ! 확인해주세요 !";       

        public const string MSG_PROCESSING = "시작할까요?";
        public const string MSG_PROCESSING_HEADER = "Processing";


        public const string WEB_NAVER_DIC_URL_WORD = "https://en.dict.naver.com/#/search?range=word&query=";
        public const string WEB_NAVER_DIC_URL_SYN = "https://en.dict.naver.com/#/search?range=thesaurus&query=";
        public const string WEB_NAVER_DIC_URL_EXP = "https://en.dict.naver.com/#/search?range=english&query=";
    }
}
