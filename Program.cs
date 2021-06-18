using System;
using System.Collections.Generic;
namespace Hellocs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //USD rates of given currencies 
            const double cad_IN_USD = 0.83;
            const double eur_IN_USD = 1.22;
            const double aud_IN_USD = 0.77;
            const double cny_IN_USD = 0.16;
            const double gbp_IN_USD = 1.42;
            const double mxn_IN_USD = 0.050;
            const double krw_IN_USD = 0.00090;
            const double inr_IN_USD = 0.014;
            const double brl_IN_USD = 0.20;
            //usd in different currencies rate 
            const double usd_in_CAD = 1.21;
            const double usd_in_EUR = 0.82;
            const double usd_in_AUD = 1.29;
            const double usd_in_CNY = 6.39;
            const double usd_in_GBP = 0.71;
            const double usd_in_MXN = 19.66; 
            const double usd_in_KRW = 1112.60;
            const double usd_in_INR = 73.10;
            const double usd_in_BRL = 5.06;

            var userresp = new HashSet<string>{"YES","Y","NO","N"};
            string ans;
            do{
                Console.WriteLine("********Currency Covertor*********** ");
                Console.WriteLine("Select which currency you want to convert?");
                Console.WriteLine("1.USD 2.CAD 3.EUR 4.AUD 5.CNY 6.GBP 7. MXN 8.KRW 9.INR 10.BRL");
                string choice = Console.ReadLine();
                Console.WriteLine("enter the amount you want to convert");
                double amount = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("select the currency in which you want to convert");
                string cur2 = Console.ReadLine();
                
                switch(choice){
                    case "usd":
                        if(cur2 == "cad"){
                            double usd_amount = amount*usd_in_CAD;
                            Console.WriteLine($"{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ", usd_amount);
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_amount);
                        }
                        
                        else if(cur2 == "cny"){
                            double usd_amount = amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_amount);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_amount);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_amount);
                        }
                        else if(cur2 == "krw"){
                            double usd_amount = amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_amount);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_amount);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_amount);
                        }
                        break;
                    case "cad":
                        if(cur2 == "usd"){
                        double usd_amount = amount*cad_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_eur = usd_amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ",usd_to_eur );
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "cny"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "krw"){                 
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                        
                        break;

                    case "eur":
                     if(cur2 == "usd"){
                        double usd_amount = amount*eur_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "cad"){
                            double usd_amount = amount*eur_IN_USD;
                            double usd_to_cad = usd_amount*usd_in_CAD;
                            Console.WriteLine("{0} is in ", usd_to_cad);
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*eur_IN_USD;
                            double usd_to_aud = usd_amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_to_aud);
                        }
                        else if(cur2 == "cny"){
                            double usd_amount = amount*eur_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*eur_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*eur_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "krw"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*cad_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                        break;
                    case "aud":
                     if(cur2 == "usd"){
                        double usd_amount = amount*aud_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "cad"){
                            double usd_amount = amount*aud_IN_USD;
                            double usd_to_cad = usd_amount*usd_in_CAD;
                            Console.WriteLine("{0} is in ", usd_to_cad);
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*aud_IN_USD;
                            double usd_to_aud = usd_amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ", usd_to_aud);
                        }
                        else if(cur2 == "cny"){
                            double usd_amount = amount*aud_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*aud_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*aud_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "krw"){
                            double usd_amount = amount*aud_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*aud_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*aud_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                        break;
                    case "cny":
                    if(cur2 == "usd"){
                        double usd_amount = amount*cny_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "cad"){
                            double usd_amount = amount*cny_IN_USD;
                            double usd_to_cad = usd_amount*usd_in_CAD;
                            Console.WriteLine("{0} is in ", usd_to_cad);
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*cny_IN_USD;
                            double usd_to_aud = usd_amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_to_aud);
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*cny_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*cny_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*cny_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "krw"){
                            double usd_amount = amount*cny_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*cny_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*cny_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                        break;
                    case "gbp":
                     if(cur2 == "usd"){
                        double usd_amount = amount*gbp_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "cad"){
                            double usd_amount = amount*gbp_IN_USD;
                            double usd_to_cad = usd_amount*usd_in_CAD;
                            Console.WriteLine("{0} is in ", usd_to_cad);
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*gbp_IN_USD;
                            double usd_to_aud = usd_amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_to_aud);
                        }
                        else if(cur2 == "cny"){
                            double usd_amount = amount*gbp_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*gbp_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*gbp_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "krw"){
                            double usd_amount = amount*gbp_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*gbp_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*gbp_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                        break;
                    case "mxn":
                     if(cur2 == "usd"){
                        double usd_amount = amount*mxn_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "cad"){
                            double usd_amount = amount*mxn_IN_USD;
                            double usd_to_cad = usd_amount*usd_in_CAD;
                            Console.WriteLine("{0} is in ", usd_to_cad);
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*mxn_IN_USD;
                            double usd_to_aud = usd_amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_to_aud);
                        }
                        else if(cur2 == "cny"){
                            double usd_amount = amount*mxn_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*mxn_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*mxn_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "krw"){
                            double usd_amount = amount*mxn_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*mxn_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*mxn_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                    break;
                    case "krw":
                     if(cur2 == "usd"){
                        double usd_amount = amount*krw_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "cad"){
                            double usd_amount = amount*krw_IN_USD;
                            double usd_to_cad = usd_amount*usd_in_CAD;
                            Console.WriteLine("{0} is in ", usd_to_cad);
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*krw_IN_USD;
                            double usd_to_aud = usd_amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_to_aud);
                        }
                        else if(cur2 == "cny"){
                            double usd_amount = amount*krw_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*krw_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*krw_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*krw_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*krw_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*krw_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                        break;
                    case "inr":
                    if(cur2 == "usd"){
                        double usd_amount = amount*inr_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "cad"){
                            double usd_amount = amount*inr_IN_USD;
                            double usd_to_cad = usd_amount*usd_in_CAD;
                            Console.WriteLine("{0} is in ", usd_to_cad);
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*inr_IN_USD;
                            double usd_to_aud = usd_amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_to_aud);
                        }
                        else if(cur2 == "cny"){
                            double usd_amount = amount*inr_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*inr_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*inr_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "krw"){
                            double usd_amount = amount*inr_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*inr_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "brl"){
                            double usd_amount = amount*inr_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_BRL;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                        break;

                    case "brl":
                         if(cur2 == "usd"){
                        double usd_amount = amount*brl_IN_USD;
                        Console.WriteLine("{0} is in ", usd_amount); 
                        }
                        else if(cur2 == "cad"){
                            double usd_amount = amount*brl_IN_USD;
                            double usd_to_cad = usd_amount*usd_in_CAD;
                            Console.WriteLine("{0} is in ", usd_to_cad);
                        }
                        else if(cur2 == "aud"){
                            double usd_amount = amount*brl_IN_USD;
                            double usd_to_aud = usd_amount*usd_in_AUD;
                            Console.WriteLine("{0} is in ", usd_to_aud);
                        }
                        else if(cur2 == "cny"){
                            double usd_amount = amount*brl_IN_USD;
                            double usd_to_cny = usd_amount*usd_in_CNY;
                            Console.WriteLine("{0} is in ", usd_to_cny);
                        }
                        else if(cur2 == "gbp"){
                            double usd_amount = amount*brl_IN_USD;
                            double usd_to_gbp = usd_amount*usd_in_GBP;
                            Console.WriteLine("{0} is in ", usd_to_gbp);
                        }
                        else if(cur2 == "mxn"){
                            double usd_amount = amount*brl_IN_USD;
                            double usd_to_mxn = usd_amount*usd_in_MXN;
                            Console.WriteLine("{0} is in ", usd_to_mxn);
                        }
                        else if(cur2 == "krw"){
                            double usd_amount = amount*brl_IN_USD;
                            double usd_to_krw = usd_amount*usd_in_KRW;
                            Console.WriteLine("{0} is in ", usd_to_krw);
                        }
                        else if(cur2 == "inr"){
                            double usd_amount = amount*brl_IN_USD;
                            double usd_to_inr = usd_amount*usd_in_INR;
                            Console.WriteLine("{0} is in ", usd_to_inr);
                        }
                        else if(cur2 == "eur"){
                            double usd_amount = amount*brl_IN_USD;
                            double usd_to_brl = usd_amount*usd_in_EUR;
                            Console.WriteLine("{0} is in ", usd_to_brl);
                        }
                        break;
                    } 
                    Console.WriteLine("enter 'y' for continue :");
                    ans = Console.ReadLine(); 
            }while(userresp.Contains(ans));
        }
    }
}


