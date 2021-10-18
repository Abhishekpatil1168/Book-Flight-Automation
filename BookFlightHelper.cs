using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace HappyFlight
{
    class FlightHelper
    {
        public static void IsSucecssfunction(bool issucess)
        {
            if (issucess)
                Console.WriteLine("PROGRAM SUCCESSFULLY EXECUTED\n\n");
            else
                Console.WriteLine("\n PROGRAM NOT* SUCCESSFULLY EXECUTED\n\n");
            do
            {
                Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
            } while (!(String.Equals(ch, "1") || String.Equals(ch, "2")));
        }

        public static void GetInfo(out bool oneway, out bool roundtrip, out string str_fromCityChoiceNumber, out string str_toCityChoiceNumber, out string toDepartureDateChoice, out string toReturnDateChoice , out string nameClassChoice, out uint numberofAdults, out uint numberofChildren, out uint numberofInfants)
        {
            Console.WriteLine("\n________________________________________________________________________________________________________________");
            string ch;
            do
            {
                Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
            } while (!(String.Equals(ch, "1") || String.Equals(ch, "2")));

            if (String.Equals(ch, "1"))
            {
                Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
                oneway = true;
                roundtrip = false;
            }
            else
            {
                oneway = false;
                roundtrip = true;
            }
            Console.WriteLine("\n________________________________________________________________________________________________________________");

            Console.WriteLine("\n\nPress Code(1/2/3/4) From** which city/airport you want departure:[more than 3 character]");
            Console.WriteLine("\n1.Mumbai   2.Delhi   3.Kolkata   4.NewYork   5.Abu Dhabi");
            do
            {
                Console.WriteLine("Enter Which City you want correctly :: ");
                str_fromCityChoiceNumber = Console.ReadLine();
            } while (!(String.Equals(str_fromCityChoiceNumber, "1") || String.Equals(str_fromCityChoiceNumber, "2") || String.Equals(str_fromCityChoiceNumber, "3") || String.Equals(str_fromCityChoiceNumber, "4") || String.Equals(str_fromCityChoiceNumber, "5")));

            Console.WriteLine("\n\nPress Code(1/2/3/4) To** which city/airport you want departure:[more than 3 character]");
            Console.WriteLine("\n1.Mumbai   2.Delhi   3.Kolkata   4.NewYork   5.Abu Dhabi");
            do
            {
                Console.WriteLine("Enter Which City you want correctly :: ");
                str_toCityChoiceNumber = Console.ReadLine();
                while(String.Equals(str_toCityChoiceNumber, str_fromCityChoiceNumber))
                {
                    Console.WriteLine("Enter Which City you want correctly :: ");
                    str_toCityChoiceNumber = Console.ReadLine();
                    Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
                }
            } while (!( String.Equals(str_toCityChoiceNumber, "1") || String.Equals(str_toCityChoiceNumber, "2") || String.Equals(str_toCityChoiceNumber, "3") || String.Equals(str_toCityChoiceNumber, "4") || String.Equals(str_fromCityChoiceNumber, "5")));
            Console.WriteLine("\n________________________________________________________________________________________________________________\n");                             

            Console.WriteLine("\n\nPress Code(1/2/3/4) For Departure Date:");
            Console.WriteLine("\n1.{0}   2.{1}   3.{2}   4.{3}   5.{4}", DateTime.Today, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today.AddDays(3), DateTime.Today.AddDays(4));
            do
            {
                Console.WriteLine("Enter Which Date choice you want correctly :: ");
                toDepartureDateChoice = Console.ReadLine();
            } while (!(String.Equals(toDepartureDateChoice, "1") || String.Equals(toDepartureDateChoice, "2") || String.Equals(toDepartureDateChoice, "3") || String.Equals(toDepartureDateChoice, "4") || String.Equals(toDepartureDateChoice, "5")));

            Console.WriteLine("\n\nPress Code(1/2/3/4) For Return Date");
            Console.WriteLine("\n1.{0}   2.{1}   3.{2}   4.{3}   5.{4}", DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today.AddDays(3), DateTime.Today.AddDays(4), DateTime.Today.AddDays(5));
            do
            {
                Console.WriteLine("Enter Which Date choice you want correctly :: ");
                toReturnDateChoice = Console.ReadLine();
            } while (!(String.Equals(toReturnDateChoice, toDepartureDateChoice) || String.Equals(toReturnDateChoice, "1") || String.Equals(toReturnDateChoice, "2") || String.Equals(toReturnDateChoice, "3") || String.Equals(toReturnDateChoice, "4") || String.Equals(toReturnDateChoice, "5")));
            Console.WriteLine("\n________________________________________________________________________________________________________________\n");

            do
            {
                Console.Write("Enter Class number(1/2/3/4): 1.Economy     2.Business      3.First     4.Premium Economy  \n ");
                nameClassChoice = Console.ReadLine();
            } while (!(String.Equals(nameClassChoice, "1") || String.Equals(nameClassChoice, "2") || String.Equals(nameClassChoice, "3") || String.Equals(nameClassChoice, "4")));
            
            Console.WriteLine("\n________________________________________________________________________________________________________________\n");
Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
            Console.Write("Enter Number of ADULTS: \n ");
            while (!(UInt32.TryParse(Console.ReadLine(), out numberofAdults) && numberofAdults <= 9))
                Console.Write("The value must be of positive integer type &<={0}, try again:\n",9);

            Console.Write("Enter Number of Children: \n ");
            while (!(UInt32.TryParse(Console.ReadLine(), out numberofChildren) && (numberofChildren) <= 6))
                Console.Write("The value must be of positive integer type & <={0}, try again :\n", 6);

            Console.Write("Enter Number of Infants: \n ");
            while (!(UInt32.TryParse(Console.ReadLine(), out numberofInfants) && numberofInfants <= 6))
                Console.Write("The value must be of positive integer type & <={0}, try again:\n", 6);
            Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
            Console.WriteLine("\n________________________________________________________________________________________________________________");
            Console.WriteLine("\n________________________________________________________________________________________________________________\n");

        }

        public static bool OpenUrl(string url)
        {
            try
            {
                Global.driver.Navigate().GoToUrl(url);
                Thread.Sleep(1000);
                if (Global.driver.PageSource.Contains("Sign In"))
                {
                    return true;
                }
                else
                {
                    return false;
                    Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                do
            {
                Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
            } while (!(String.Equals(ch, "1") || String.Equals(ch, "2")));
                Console.WriteLine("FAILURE::URL did not load/valid: " + Global.test_url);
                return false;
            }
        }

        public static bool IsElementPresent(By by)
        {
            try
            {
                if (Global.driver.FindElement(by) != null)
                {
                    do
            {
                Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
            } while (!(String.Equals(ch, "1") || String.Equals(ch, "2")));
                    return true;
                }
                else
                {
                    Console.WriteLine("IsELEMENT={0}   -->>> is NULL !", by);
                    throw new TestException("IsElementPresent did not load");
                }

            }
            catch (NoSuchElementException)
            {
                throw new TestException("IsElementPresent did not load");
            }
        }

        public static void ClickIfPresent(By by)
        {
            try
            {
                if (IsElementPresent(by))
                {
                    Global.driver.FindElement(by).Click();
                    Console.WriteLine("{0} Clicked !!",by.ToString());
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("NOT CLICKED {0} ", by);
                    Thread.Sleep(1000);
                    throw new TestException("ClickIfPresent did not load");
                }
            }
            catch
            {
                do
            {
                Console.WriteLine("Enter Which TripType you want: \nOneWay: Press 1\nRoundTrip: Press 2:");
                ch = Console.ReadLine();
            } while (!(String.Equals(ch, "1") || String.Equals(ch, "2")));
                throw new TestException("ClickIfPresent did not load");
            }
        }

        public static void SendKeysIfPresent(By by, string sendkeys)
        {
            try
            {
                if (IsElementPresent(by))
                {
                    Global.driver.FindElement(by).Clear();
                    Thread.Sleep(1000);
                    Global.driver.FindElement(by).SendKeys(sendkeys);
                    Thread.Sleep(500);
                    Console.WriteLine("Send Keys--> {0} to {1} ", sendkeys, by);
                }
                else
                {
                    Console.WriteLine("NOT CLICKED {0} ", by);
                    throw new TestException("SendKeysIfPresent did not load");
                }
            }
            catch
            {
                throw new TestException("SendKeysIfPresent did not load");
            }
        }


        public static bool TravolookLogin()
        {
            try
            {
                Thread.Sleep(1000);
                string phone = "9423270662";
                string password = "Ready2wrkNVIDIA";

                ClickIfPresent(By.XPath("//a[@id='getSignIn']"));
                Thread.Sleep(1000);

                Global.driver.SwitchTo().ParentFrame();
                IWebDriver iframeDriver = Global.driver.SwitchTo().Frame(Global.driver.FindElement(By.Id("login-register")));
                SendKeysIfPresent(By.Id("user_phone"),  phone);

                Console.WriteLine("\n\nUser 'Phone Number' Inserted Sucessfully");
                Thread.Sleep(500);

                SendKeysIfPresent(By.XPath("//input[@id='password']"),password);
                Console.WriteLine("\nUser 'Password' Inserted Sucessfully");
                Thread.Sleep(500);

                ClickIfPresent(By.XPath("//button[@id='login-btn']"));
                Console.WriteLine("\n'Login Button'Pressed Sucessfully\n\n");
                Thread.Sleep(500);
                Global.driver.SwitchTo().Window(Global.driver.WindowHandles.Last());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("FAILURE: {0}:FlightLogin did not load.");
                return false;
            }
        }


        public static string SetCity(string CityCode)
        {
            try
            {
                string CityName;
                if (String.Equals(CityCode, "1"))
                {
                    CityName = "Mumbai(BOM)";
                }
                else if (String.Equals(CityCode, "2"))
                {
                    CityName = "Delhi(DEL)";
                }
                else if (String.Equals(CityCode, "3"))
                {
                    CityName = "Kolkata(CCU)";
                }
                else if (String.Equals(CityCode, "4"))
                {
                    CityName = "NewYork(FLU)";
                }
                else
                {
                    CityName = "Abu Dhabi(AUH)";
                }
                return CityName;
            }
            catch
            {
                throw new TestException("SetCity did not load");
            }
        }


        public static string SetDate(string DateCode)
        {
            try
            {
                string DateName;
                if (String.Equals(DateCode, "1"))
                {
                    DateName = Convert.ToString(DateTime.Today.Date);
                }
                else if (String.Equals(DateCode, "2"))
                {
                    DateName = Convert.ToString(DateTime.Today.AddDays(1).Date);
                }
                else if (String.Equals(DateCode, "3"))
                {
                   DateName = Convert.ToString(DateTime.Today.AddDays(2).Date);
                }
                else if (String.Equals(DateCode, "4"))
                {
                    DateName = Convert.ToString(DateTime.Today.AddDays(3).Date);
                }
                else
                {
                    DateName = Convert.ToString(DateTime.Today.AddDays(4).Date);
                }
                return DateName;
            }
            catch
            {
                throw new TestException("SetCity did not load");
            }
        }

        public static void InsertSearch(IWebDriver driver, bool oneway, bool roundtrip, string str_fromCityChoiceNumber, string str_toCityChoiceNumber, string toDepartureDateChoice,  string toReturnDateChoice, string nameClassChoice, uint numberofAdults, uint numberofChildren, uint numberofInfants)
        {
            string fromCityName = string.Empty, toCityName = string.Empty;
            string toDepartureDate = string.Empty, toReturnDate = string.Empty;
            try
            {
                Thread.Sleep(2000);
                fromCityName = SetCity(str_fromCityChoiceNumber);
                toCityName = SetCity(str_toCityChoiceNumber);
                toDepartureDate = SetDate(toDepartureDateChoice);
                toReturnDate = SetDate(toReturnDateChoice);
                ClickIfPresent(By.XPath("//a[@data-role='flight']"));
                ClickIfPresent(By.XPath(" //button[@id='search_flights']"));

                if (oneway)
                {
                    ClickIfPresent(By.XPath("//form[@id='searchForm']/div[1]/nav/ul/li[1]/label/strong"));
                }
                if (roundtrip)
                {
                    ClickIfPresent(By.XPath("//form[@id='searchForm']/div[1]/nav/ul/li[2]/label/strong"));
                }

                SendKeysIfPresent(By.Id("D_city"),  fromCityName);
                Thread.Sleep(2000);
                SendKeysIfPresent(By.Id("A_city"),  toCityName);
                Thread.Sleep(3000);
                SendKeysIfPresent(By.Id("D_date"),  toDepartureDate);
                Thread.Sleep(2000);
                SendKeysIfPresent(By.Id("R_date"),  toReturnDate);
                Thread.Sleep(3000);

                ClickIfPresent(By.XPath("/input[@id='chose-person']"));
                string adultNumbers="//form[@id='searchForm']/div[4]/div[2]/div[1]/ul/li["+ numberofAdults + "]";
                string ChildrenNumbers="//form[@id='searchForm']/div[4]/div[2]/div[1]/ul/li["+ numberofChildren + "]";
                string InfantsNumbers="//form[@id='searchForm']/div[4]/div[2]/div[1]/ul/li["+ numberofInfants + "]";
                string nameClass = "//form[@id='searchForm']/div[4]/div[2]/div[3]/ul/li[" + nameClassChoice + "]";

                ClickIfPresent(By.XPath(adultNumbers));
                ClickIfPresent(By.XPath(ChildrenNumbers));
                ClickIfPresent(By.XPath(InfantsNumbers));
                ClickIfPresent(By.XPath(nameClass));
                ClickIfPresent(By.ClassName("apply-btn"));
                ClickIfPresent(By.XPath("//button[@id='search_flights_btn']"));

                Thread.Sleep(3000);
                ClickIfPresent(By.XPath("//div[@id='f_title']/div/div/i"));
                ClickIfPresent(By.ClassName("sort-price"));
                Thread.Sleep(1000);

                if (IsElementPresent(By.XPath("//div[@id='6E2939 / 6E685']/ul/li/div/div[2]/div[1]/div[1]/span[2]")))
                {
                    String minimumCost = driver.FindElement(By.XPath("//div[@id='6E2939 / 6E685']/ul/li/div/div[2]/div[1]/div[1]/span[2]")).Text;
                    Console.WriteLine("\n________________________________________________________________________________________________________________\n");
                    Console.WriteLine("Minimum Cost of THAT DAY FLIGHT {0}",minimumCost);
                    Console.WriteLine("\n________________________________________________________________________________________________________________\n");
                }
                else
                {
                    throw new TestException("No result Found did not load.");
                }
                
                Thread.Sleep(1000);
                ClickIfPresent(By.XPath("//a[@id='6E2939 / 6E685']/ul/li/div/div[2]/div[2]/a"));
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                ClickIfPresent(By.XPath("//a[@data-index='0' and @data-type='1']"));
                Console.WriteLine("\n'BOOK Button'Pressed Sucessfully");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
            }
            catch (Exception e)
            {
                Console.WriteLine("FAILURE::Insertsearch did not load.{0}", e);
                throw new TestException("Insertsearch did not load.");
            }
        }
    }
}

















