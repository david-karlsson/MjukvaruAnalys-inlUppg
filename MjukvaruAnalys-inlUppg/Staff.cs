using System;
using System.Collections.Generic;
using System.Text;

namespace MjukvaruAnalys_inlUppg
{
    class Staff
    {
        public int StaffID { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

            
            
                     public string GetRandomStaffMember()
                        {


                    Random rndName = new Random();


                    string[] personellNames = new string[3];
                    personellNames[0] = "Jimmy";
                    personellNames[1] = "Timmy";
                    personellNames[2] = "Ursula";



                    var name = personellNames[rndName.Next(0, 3)];

                           Name = name;


                                     return name;
    
                     }


                  public string GetRandomStaffRole()
                            {
                                Random rndRole = new Random();


                                string[] personellRoles = new string[3];
                                personellRoles[0] = "Captain";
                                personellRoles[1] = "Steward";
                                personellRoles[2] = "Chef";



                                var role = personellRoles[rndRole.Next(0, 3)];
                                    return role;

                            }






                        public void ServeDrink()
                                        {



                            Console.WriteLine("Serving you today will be: " + GetRandomStaffRole()+" " + GetRandomStaffMember()) ;
   



                                        }



            }









}
