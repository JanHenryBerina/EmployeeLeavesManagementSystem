using System;

namespace EmployeeLeavesManagementSystem2
{
    class Program
    {
        static void Main(string[] args)
        {
         	    string choiceOfPlan = "Yes";
            string choiceOfPlan2 = "No";
            string departments = "Production";
            string departments2 = "Research and Development";
            string departments3 = "Purchasing";
           string leaveDate = "Tomorrow";
            string name = "Jan Henry Berina";
            string ID = "123456789";
            string reason = "Maternity";
            string reason2 = "Paternity";
            string reason3 = "Parental";
            
            
            Console.WriteLine("WELCOME TO EMPLOYEE LEAVES PLAN MANAGEMENT!");
            
                
            {
            
                Console.Write("Please Enter Your Name: ");
                string emplopyeeName = Console.ReadLine();
                
                Console.Write("Please Enter Your Employees ID: ");
                string employeesId = Console.ReadLine();

                Console.WriteLine("(Production),(Research and Development),(Purchasing)");
                Console.Write("Please Choose What Your Department is: ");
                string employeesDepartment = Console.ReadLine();


                Console.WriteLine("Plan on leaving? Please Enter Yes or No");
                Console.Write("Enter Here: ");
                string choiceAnswer = Console.ReadLine();

                




                if (choiceAnswer == choiceOfPlan && emplopyeeName == name && employeesId == ID && (employeesDepartment == departments || employeesDepartment == departments2 || employeesDepartment == departments3))
                {
                    Console.WriteLine("When do you plan on leaving?");
                    string date = Console.ReadLine();
                    
                    if(date == leaveDate){
                  Console.WriteLine("PLEASE INDICATE YOUR REASON OF LEAVE:");
                  Console.WriteLine("Choose Whether it is Maternity, Paternity, Parental");
                  string leaveReason = Console.ReadLine();
                    if(leaveReason == reason || leaveReason == reason2 || leaveReason == reason3){
                      Console.WriteLine("*EMPLOYEE LEAVE REGISTERED*");
                      Console.WriteLine("Your Name: " +name);
                      Console.WriteLine("Your ID: "+ ID);
                      Console.WriteLine("Your Department: " + employeesDepartment);
                      Console.WriteLine("Your Reason of Leave: " + leaveReason);
                      Console.WriteLine("Thank You! :) "+ name);
                    }
                  }
                }
                else if (choiceAnswer == choiceOfPlan2)
                {
                    Console.WriteLine("Thankyou System will Exit!");
                }
                else if (choiceAnswer != choiceOfPlan ||emplopyeeName != name || employeesId != ID || employeesDepartment != departments || employeesDepartment != departments2 || employeesDepartment != departments3)
                {
                    Console.WriteLine("Invalid Information Please Check Again"); 
                }

                }

            }

        }
    }
