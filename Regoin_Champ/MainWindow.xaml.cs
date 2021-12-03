﻿using Regoin_Champ.db;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Regoin_Champ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var connection = DBInstance.Get();
            //string path = @"C:\Users\user\Desktop\КЗ_РЧ20_21_Основная группа\Session 1\services.csv";
            //var rows = File.ReadAllLines(path);
            //var patients = connection.Patient.ToList();
            //var services = connection.Service_lab.ToList();
            //var paswordslogins = connection.PasswordsLogins.ToList();
            //for (int i = 1; i < rows.Length; i++)
            //{
            //    var cols = rows[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //    //var service = services.First(s => s.Code.ToString() == cols[0]);
            //    //label.Content +=  decimal.Parse(cols[2].Replace('.', ',')).ToString();
            //    connection.Service_lab.Add(new Service_lab
            //    {
            //        Code = int.Parse(cols[0]),
            //        Name = cols[1],
            //        Cost = decimal.Parse(cols[2].Replace('.', ','))
            //    });
            //}
            //connection.SaveChanges();
            //var connection = DBInstance.Get();
            //string path = @"C:\Users\user\Desktop\КЗ_РЧ20_21_Основная группа\Session 1\users.csv";
            //var rows = File.ReadAllLines(path);
            //var laborants = connection.Laborant.ToList();
            //var services = connection.Service_lab.ToList();
            //var paswordslogins = connection.PasswordsLogins.ToList();

        
            
            //for (int i = 1; i < rows.Length; i++)
            //{
            //    var cols = rows[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            //    cols[5].Replace('/', '-');
            //    var name = cols[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //var service = services.First(s => s.Code.ToString() == cols[0]);
                //temp[] codes;
                //using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(cols[6].Substring(1, cols[6].Length - 2))))
                //{
                //    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(temp[]));
                //    codes = (temp[])deserializer.ReadObject(ms);
                //    //label.Content += bsObj2;
                //}
                //Laborant laborant = new Laborant{ 
                //    FirstName = name[0],
                //    LastName = name[1],
                //    PasswordsLogins = new PasswordsLogins { Login = cols[2], Password = cols[3] },
                //    Ip = cols[4],
                //    Lastenter = cols[5],
                //    Type = int.Parse(cols[7]) }
                //    ;
                //for (int a = 0; a < codes.Length; a++)
                //{
                //    laborant.Service_lab.Add(services.First(s => s.Code == codes[a].code));
                //}
                //connection.Laborant.Add(laborant);

                //label.Content += "\n";
                //foreach (var ser in laborant.Service_lab)
                //{
                //    label.Content += ser.Code.ToString();
                //}
                
                //label.Content += $"{codes[0].code.ToString()} \n";
            }

      

        private void revealModeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (revealModeCheckBox.IsChecked == true)
            {
                statusText.Text = passwordBox.Password;
            }
            else
            {
                statusText.Text = string.Empty;
            }
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (revealModeCheckBox.IsChecked == true)
            {
                statusText.Text = passwordBox.Password;
            }
            else
            {
                statusText.Text = string.Empty;
            }
        }


        //connection.SaveChanges();
    }
    }

    //[DataContract]
    //public class temp 
    //{
    //    [DataMember]
    //    public int code;
    //}
//}