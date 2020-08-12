﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

        public LoginHelper Auth { get; }
        public NavigationHelper Navigator { get; }
        public GroupHelper Groups { get; }
        public ContactHelper Contacts { get; }

        public ApplicationManager()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost:8080";
            verificationErrors = new StringBuilder();

            Auth = new LoginHelper(this);
            Navigator = new NavigationHelper(this, baseURL);
            Groups = new GroupHelper(this);
            Contacts = new ContactHelper(this);

        }
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }

        }

/*        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }*/

        /*public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }*/

       /* public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }*/
/*
        public ContactHelper Contacts
        {
            get
            {
                return contactHelper;
            }
        }*/
    }
}
