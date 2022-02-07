# EnglishWordExam

## Info
The starting point was a request from my friend who is an English teacher.\
It makes easy to write English vocabulary tests.

This program searches for `meanings`, `synonyms`, and `antonyms` of english words in `Naver dictionary site` by using `Selenium` and `writes simple word test exam randomly`.

## Remain Issues
1. Automatic installation `chromedriver.exe` suitable for the user's environment.
2. Apply a language pack or Change to English version.
3. Implement a second test type.

## Exam Type
  - 시험유형
    - 단어쓰기 : Word field (A) is empty in sheet2
    - 뜻쓰기 : Meaning field (B) is empty in sheet2
    - 유의어쓰기 : Synonym field (C, D) is empty in sheet2
  - 시험유형2 _(not implemented)_
    - 단어보고 뜻 고르기
    - 뜻보고 단어 고르기
    - 동의어 모두 고르기
  - You can show the first letter of the problem if you check a box `첫글자 보여주기`.
## Sample Scene
  - ###### Install Program
    - You can run `HET_installer.msi` in root path
    - `HET.exe` and `basicForm.xlsx` will be created in your desktop.
    ![image](https://user-images.githubusercontent.com/21374902/152709070-c436713c-d34e-4510-a3cb-d3822013f66b.png)
  - ##### Pre-Setting
    - Choose the `type` and `number` of exam you want.
    - Click `Open` button and choose a file.\
      (You can use a test file `basicForm.xlsx`)
      ![image](https://user-images.githubusercontent.com/21374902/152709150-0eb004e4-fbcc-440d-9e13-90733824e30a.png)
  - ###### Running
    ![image](https://user-images.githubusercontent.com/21374902/152708198-ad6a2619-c3cf-47f2-9e1c-8028c3cc45af.png)
  - ###### Result
    - ### 🔰 Input
      ![image](https://user-images.githubusercontent.com/21374902/152708389-4f219208-d1c0-48d0-a796-a25a4025e4d4.png)
    - ### 🔰 Output
      ![image](https://user-images.githubusercontent.com/21374902/152708342-a72b4c96-9434-4ae6-95e0-93ef77772aa9.png)