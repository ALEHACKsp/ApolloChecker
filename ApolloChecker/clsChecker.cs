using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApolloChecker
{
    public class clsChecker
    {
        public frmMain _frmMain;
        public string[] _accounts;
        public string _site;

        // Nested Types
        public class OnLoginSuccess
        {
            // Properties
            public string findBy { get; set; }
            public string id_Element { get; set; }
            public string class_Name_Element { get; set; }
            public string css_Selector_Element { get; set; }
            public string x_path_element { get; set; }
            public string status_element { get; set; }
            public int position_in_NodeElements { get; set; }
        }

        public class LoginProcess
        {
            // Properties
            public int step { get; set; }
            public string operation { get; set; }
            public string id_Element { get; set; }
            public string class_Name_Element { get; set; }
            public string name_Element { get; set; }
            public string css_Selector_Element { get; set; }
            public string x_path_element { get; set; }
            public int position_in_NodeElements { get; set; }
            public string event_in_Element { get; set; }
            public bool sendKeys_UserOrEmail { get; set; }
            public bool sendKeys_Password { get; set; }
        }

        public class RootJsonConfig
        {
           
            // Properties
            public string url_login { get; set; }
            public int wait_time_login { get; set; }
            public int wait_time_between_steps { get; set; }
            public int minutes_wait_timeout { get; set; }
            public List<OnLoginSuccess> on_login_success { get; set; }
            public List<LoginProcess> login_process { get; set; }
        }

        public class RootJsonSettings
        {
            // Properties
            public char separator_combo { get; set; }
            public bool debug_mode { get; set; }
        }


        private void ProcessLogin_CheckAccounts(int accountIndex, bool debug_mode, int minutes_wait_timeout, string url_login, int wait_time_between_steps, char separator_combo, RootJsonConfig configProcessSite, IWebDriver driver, FirefoxDriverService service, FirefoxOptions options)
        {
            driver.Navigate().GoToUrl(url_login);

            Thread.Sleep(wait_time_between_steps);


            foreach (LoginProcess LoginProcess in configProcessSite.login_process)
            {
                string SearchElementBy = LoginProcess.operation;

                string className = LoginProcess.class_Name_Element;
                int position_class = LoginProcess.position_in_NodeElements;
                string event_class = LoginProcess.event_in_Element;

                string idName = LoginProcess.id_Element;
                string event_id = LoginProcess.event_in_Element;

                string cssSelector = LoginProcess.css_Selector_Element;
                int position_cssSelector = LoginProcess.position_in_NodeElements;
                string event_cssSelector = LoginProcess.event_in_Element;

                string xpath = LoginProcess.x_path_element;
                string event_xpath = LoginProcess.event_in_Element;



                if (SearchElementBy == "FindElementsByClassName")
                {
                    if (event_class == "Click")
                    {
                        driver.FindElements(By.ClassName(className))[position_class].Click();
                    }
                    else if (event_class == "SendKeys")
                    {
                      
                        if (LoginProcess.sendKeys_UserOrEmail)
                        {
                            driver.FindElements(By.ClassName(className))[position_class].SendKeys(this._accounts[accountIndex].Split(separator_combo)[0]);
                        }
                        if (LoginProcess.sendKeys_Password)
                        {
                            driver.FindElements(By.ClassName(className))[position_class].SendKeys(this._accounts[accountIndex].Split(separator_combo)[1]);
                        }
                    }
                }

                if (SearchElementBy == "FindElementByID")
                {
                    if (event_id == "Click")
                    {
                       
                        driver.FindElement(By.Id(idName)).Click();
                    }
                    else if (event_id == "SendKeys")
                    {
                       

                        if (LoginProcess.sendKeys_UserOrEmail)
                        {
                            driver.FindElement(By.Id(idName)).SendKeys(this._accounts[accountIndex].Split(separator_combo)[0]);
                        }
                        if (LoginProcess.sendKeys_Password)
                        {

                            driver.FindElement(By.Id(idName)).SendKeys(this._accounts[accountIndex].Split(separator_combo)[1]);
                        }
                    }
                }
                if (SearchElementBy == "FindElementsByCssSelector")
                {
                   
                    if (event_cssSelector == "Click")
                    {
                        
                        driver.FindElements(By.CssSelector(cssSelector))[position_cssSelector].Click();
                    }
                    else if (event_cssSelector == "SendKeys")
                    {
                        if (LoginProcess.sendKeys_UserOrEmail)
                        {
                            driver.FindElements(By.CssSelector(cssSelector))[position_cssSelector].SendKeys(this._accounts[accountIndex].Split(separator_combo)[0]);
                        }
                        if (LoginProcess.sendKeys_Password)
                        {

                            driver.FindElements(By.CssSelector(cssSelector))[position_cssSelector].SendKeys(this._accounts[accountIndex].Split(separator_combo)[1]);
                        }
                    }
                }
                if (SearchElementBy == "FindElementByXPath")
                {
                   
                    if (event_xpath == "Click")
                    {
                        
                        driver.FindElement(By.XPath(xpath)).Click();
                    }
                    else if (event_xpath == "SendKeys")
                    {
                       
                        if (LoginProcess.sendKeys_UserOrEmail)
                        {
                            driver.FindElement(By.XPath(xpath)).SendKeys(this._accounts[accountIndex].Split(separator_combo)[0]);
                        }
                        if (LoginProcess.sendKeys_Password)
                        {

                            driver.FindElement(By.XPath(xpath)).SendKeys(this._accounts[accountIndex].Split(separator_combo)[1]);
                        }
                    }
                }

                Thread.Sleep(wait_time_between_steps);
            }
        }


        private void ProcessOnSucessLogin_CheckAccounts(string idRandomConfig, Label _labelAccountsWorking, Label _labelAccountsNotWorking, int accountIndex, char separator_combo, int wait_time_login, RootJsonConfig configProcessSite, IWebDriver driver)
        {
            Thread.Sleep(wait_time_login);

            try
            {
                foreach (OnLoginSuccess OnLoginSuccess in configProcessSite.on_login_success)
                {


                    string className = OnLoginSuccess.class_Name_Element;
                    string idName = OnLoginSuccess.id_Element;
                    string cssSelector = OnLoginSuccess.css_Selector_Element;
                    string status_Element = OnLoginSuccess.status_element;
                    string xpath = OnLoginSuccess.x_path_element;
                    int position_Element = OnLoginSuccess.position_in_NodeElements;
                    string findBy = OnLoginSuccess.findBy;


                    if (findBy == "ID")
                    {
                        if (status_Element == "Displayed")
                        {
                            if (driver.FindElement(By.Id(idName)).Displayed)
                            {
                                clsUtils.updateAccountsWorking(_labelAccountsWorking, _frmMain);
                                clsUtils.saveAccountsWorkTempFile(idRandomConfig, this._accounts[accountIndex].Split(separator_combo)[0], this._accounts[accountIndex].Split(separator_combo)[1], this._site);
                            }
                        }  
                    }
                    if (findBy == "Css Selector")
                    {

                        if (status_Element == "Displayed")
                        {
                            if (driver.FindElements(By.CssSelector(cssSelector))[position_Element].Displayed)
                            {
                                clsUtils.updateAccountsWorking(_labelAccountsWorking, this._frmMain);
                                clsUtils.saveAccountsWorkTempFile(idRandomConfig, this._accounts[accountIndex].Split(separator_combo)[0], this._accounts[accountIndex].Split(separator_combo)[1], this._site);
                            }
                        }
                    }

                    if (findBy == "Class Name")
                    {
                        if (status_Element == "Displayed")
                        {
                            if (driver.FindElements(By.ClassName(className))[position_Element].Displayed)
                            {
                                clsUtils.updateAccountsWorking(_labelAccountsWorking, this._frmMain);
                                clsUtils.saveAccountsWorkTempFile(idRandomConfig, this._accounts[accountIndex].Split(separator_combo)[0], this._accounts[accountIndex].Split(separator_combo)[1], this._site);
                            }
                        }

                      
                    }
                    if (findBy == "X Path")
                    {

                        if (status_Element == "Displayed")
                        {
                            if (driver.FindElement(By.XPath(xpath)).Displayed)
                            {
                                clsUtils.updateAccountsWorking(_labelAccountsWorking, this._frmMain);
                               clsUtils.saveAccountsWorkTempFile(idRandomConfig, this._accounts[accountIndex].Split(separator_combo)[0], this._accounts[accountIndex].Split(separator_combo)[1], this._site);
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {
                clsUtils.updateAccountsNotWorking(_labelAccountsNotWorking, this._frmMain);
            }
        }
        public void checkAccounts(string idRandomConfig, Label _labelAccountsWorking, Label _labelAccountsNotWorking, Label _labelChecked, Label _labelProgress)
        {

            RootJsonSettings settingsSite = JsonConvert.DeserializeObject<RootJsonSettings>(clsUtils.getSettingsJSON());
            RootJsonConfig configProcessSite = JsonConvert.DeserializeObject<RootJsonConfig>(clsUtils.returnProcessLogin(this._site));

            char separator_combo = settingsSite.separator_combo;
            bool debug_mode = settingsSite.debug_mode;

            int wait_time_login = configProcessSite.wait_time_login;
            int wait_time_between_steps = configProcessSite.wait_time_between_steps;
            string url_login = configProcessSite.url_login;
            int minutes_wait_timeout = configProcessSite.minutes_wait_timeout;
           
            for (int i = 0; i < _accounts.Length; i++)
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                FirefoxOptions options = new FirefoxOptions();
                service.HideCommandPromptWindow = true;

                if (!debug_mode)
                {    
                    options.AddArgument("--headless");
                }


                IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(minutes_wait_timeout));

                ProcessLogin_CheckAccounts(i, debug_mode, minutes_wait_timeout, url_login, wait_time_between_steps, separator_combo, configProcessSite, driver, service, options);
                ProcessOnSucessLogin_CheckAccounts(idRandomConfig, _labelAccountsWorking, _labelAccountsNotWorking, i, separator_combo, wait_time_login, configProcessSite, driver);

                driver.Quit();

                clsUtils.updateProgress(_labelChecked, clsUtils.getSizeComboAccounts(this._accounts), _labelProgress, this._frmMain);
            }
        }



    }
}
