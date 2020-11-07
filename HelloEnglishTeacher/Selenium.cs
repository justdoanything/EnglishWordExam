using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace HelloEnglishTeacher
{
    class Selenium
    {
        private IWebDriver driver = null;
        private ChromeDriverService service = null;
        private ChromeOptions option = null;
        
        public Selenium()
        {
            SetWebDriver();
        }

        private void SetWebDriver()
        {
            service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            option = new ChromeOptions();
            // option.AddArgument("--window-position=-32000,-32000");
            option.AddArgument("headless=True");
            driver = new ChromeDriver(service, option);
        }

        public Dictionary<String, List<List<string>>> SearchEng(List<string> list)
        {
            Dictionary<String, List<List<string>>> result = new Dictionary<string, List<List<string>>>();
            try
            {
                for (int i = 0; i < list.Count; i++)
                {                 
                    List<string> meanList = new List<string>();     //단어
                    List<string> synonymList = new List<string>();  //유의어
                    List<string> antonymList = new List<string>();  //반의어
                    List<string> explainList = new List<string>();  //영영풀이

                    // 단어 뜻
                    meanList = FindMean(list[i]);

                    // 영영 풀이
                    explainList = FindExplain(list[i]);

                    // 유의어 반의어
                    driver.Navigate().GoToUrl(MsgCode.WEB_NAVER_DIC_URL_SYN + list[i]);
                    Thread.Sleep(500);
                    IList<IWebElement> synList = new List<IWebElement>();
                    synList = driver.FindElements(By.ClassName("synonym_info"));                    
                    for (int j = 0; j < synList.Count; j++)
                    {
                        string word = synList[j].Text;
                        
                        //가끔 반의어가 없고 유의어가 연달아 있는 형태를 예외처리
                        if (word.Contains("유의어") && synList.Count == 1)
                        {
                            word = word.Replace("\n", "").Replace("\r", "");
                            synonymList.AddRange(word.Replace("유의어", "").Split(' '));
                        }
                            
                        //유의어 저장
                        else if (word.Contains("유의어") && synonymList.Count < 4 && !synonymList.Contains(word = word.Replace("유의어", "").Trim()))
                        {
                            word = word.Replace("\n", "").Replace("\r","");
                            if(word.Contains(" "))
                            {
                                List<string> temp = new List<string>();
                                temp.AddRange(word.Split(' '));
                                
                                temp.RemoveAll(var => var.Equals("a"));
                                temp.RemoveAll(var => var.Equals("an"));
                                temp.RemoveAll(var => var.Equals("the"));

                                synonymList.AddRange(temp);
                            }
                            else 
                                synonymList.Add(word);
                        }
                            
                        //반의어 저장
                        else if (word.Contains("반의어") && antonymList.Count < 4 && !antonymList.Contains(word = word.Replace("반의어", "").Trim()))
                            antonymList.Add(word);
                        // 유의어, 반의어를 3개씩 채웠으면 break;
                        if (synonymList.Count >= 3 && antonymList.Count >= 3)
                            break;
                    }
                    result[list[i]] = new List<List<string>>();
                    result[list[i]].Add(meanList);
                    result[list[i]].Add(synonymList);
                    result[list[i]].Add(antonymList);
                    result[list[i]].Add(explainList);
                }
            }
            catch (Exception e) 
            {
                
            }
            finally
            {
                this.Close();
            }
            return result;
        }

        private List<string> FindMean(string word)
        {
            List<string> list = new List<string>();
            IList<IWebElement> elementList = new List<IWebElement>();
            IWebElement element;

            try
            {
                // 단어 뜻
                driver.Navigate().GoToUrl(MsgCode.WEB_NAVER_DIC_URL_WORD + word);
                Thread.Sleep(500);

                element = driver.FindElement(By.Id("searchPage_entry"));
                element = driver.FindElement(By.ClassName("row"));
                elementList = element.FindElements(By.ClassName("mean_list"));

                for (int j = 0; j < elementList.Count; j++)
                    list.Add(elementList[j].FindElement(By.ClassName("mean")).Text);
            }
            catch (Exception e)
            {
                
            }

            return list;
        }

        private List<string> FindExplain(string word)
        {
            List<string> list = new List<string>();
            IList<IWebElement> elementList = new List<IWebElement>();
            IWebElement element;
            
            try
            {
                driver.Navigate().GoToUrl(MsgCode.WEB_NAVER_DIC_URL_EXP + word);
                Thread.Sleep(500);

                element = driver.FindElement(By.Id("searchPage_entry"));
                element = driver.FindElement(By.ClassName("row"));
                elementList = element.FindElements(By.ClassName("mean"));

                for (int j = 0; j < elementList.Count; j++)
                    list.Add(elementList[j].Text);
            }
            catch (Exception e)
            {
                
            }

            return list;
        }

        public void Close()
        {
            if (driver != null) { driver.Close(); driver.Dispose();  driver = null; }
            if (service != null) { service.Dispose(); service = null; }
            if (option != null) { option = null; }
        }
    }
}
