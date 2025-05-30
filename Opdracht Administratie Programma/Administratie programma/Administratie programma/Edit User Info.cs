﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie_programma
{ 
    internal class Edit_User_Info
    {

        public void Edit(List<User> biglist) 
        {
            Console.WriteLine("Which User would you like to edit?");

            for (int i = 0; i < biglist.Count; i++)
            {
                Console.WriteLine($"{i} - User: {biglist[i].name}");
            }


            string chooseEdit = Console.ReadLine().ToLower();
            int.TryParse(chooseEdit, out int indexEdit);

            //PRINT OUT ONLY CHOSEN USER INFO
            Console.WriteLine($"what would you like to change?: ");

            //Console.WriteLine(biglist[indexEdit]);


            for (int i = 0; i < biglist.Count; i++)
            {
                if (indexEdit == biglist.IndexOf(biglist[i]))
                {
                    Console.WriteLine($"name: {biglist[i].name}  \nphone number: {biglist[i].phoneNumber} \nadress: {biglist[i].adress}");
                    String WhichInfoToChange = Console.ReadLine();


                    // check if inputted info(so the word name, phone number, adress) is equal to biglist.name or for exmp, otherwise error message. 
                    // if is correct, change string--> WhichInfoToChange = thing it is equal to

                    /* 
                        so say someone types in: name. the program needs to recognize that there is a variable called biglist.name and the user should be able to change info in biglist.name
                    
                        if user types in: dog, that would show an error as biglist.dog does not exist. and make the user allow for re-input
                     */
                    String WhatToChangeTo = "";

                    if (WhichInfoToChange == "name" || WhichInfoToChange == "phone number" || WhichInfoToChange == "adress") // biglist.name
                    {
                        if (WhichInfoToChange == "name")
                        {
                            Console.WriteLine("what would you like to change it to?: ");
                            WhatToChangeTo = Console.ReadLine();
                            biglist[i].name = WhatToChangeTo;

                            //biglist[i].name = ChangeEdit.name;
                            Console.WriteLine($" Changed {WhichInfoToChange} to: {biglist[i].name}");
                        }

                        if (WhichInfoToChange == "phone number")
                        {
                            Console.WriteLine("what would you like to change it to?: ");
                            WhatToChangeTo = Console.ReadLine();
                            int value;
                            Int32.TryParse(WhatToChangeTo, out value);

                            biglist[i].phoneNumber = value;

                            //biglist[i].phoneNumber = ChangeEdit.phoneNumber;
                            Console.WriteLine($" Changed {WhichInfoToChange} to: {biglist[i].phoneNumber}");
                            Console.WriteLine($" User: {biglist[i]}");
                        }

                        if (WhichInfoToChange == "adress")
                        {
                            Console.WriteLine("what would you like to change it to?: ");
                            WhatToChangeTo = Console.ReadLine();

                            biglist[i].adress = WhatToChangeTo;
                            //ChangeEdit.adress = WhatToChangeTo;

                            //biglist[i].adress = ChangeEdit.adress;
                            Console.WriteLine($" Changed {WhichInfoToChange} to: {biglist[i].adress}");
                        }

                        //Console.WriteLine("what would you like to change it to?: ");
                        //WhatToChangeTo = Console.ReadLine();
                        //ChangeEdit.name = WhatToChangeTo;

                        //biglist[i].name = ChangeEdit.name;
                        //Console.WriteLine($" Changed {WhichInfoToChange} to: {biglist[i].name}");
                    }
                    else
                    {
                        Console.WriteLine("does not exist please type in either name, pass, or adress");
                    }

                    //Task.Delay(2000).Wait();

                }
            }

            Console.WriteLine("druk een knop in om verder te gaan");
            string temp = Console.ReadLine();
        }
    }
}
