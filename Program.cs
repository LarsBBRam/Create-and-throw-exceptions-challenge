﻿namespace Create_and_throw_exceptions_challenge;

class Program
{
    static void Main(string[] args)
    {
        string[][] userEnteredValues =
        [
            ["1", "2", "3"],
            ["1", "two", "3"],
            ["0", "1", "2"],
        ];

        try
        {
            Workflow1(userEnteredValues);
            Console.WriteLine("Workflow1 completed successfully.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occurred during Workflow1.");
            Console.WriteLine(ex.Message);
        }

        /* Before improvement:
            string overallStatusMessage = "";

            overallStatusMessage = Workflow1(userEnteredValues);

            if (overallStatusMessage == "operating procedure complete")
            {
                Console.WriteLine("'Workflow1' completed successfully");
            }
            else
            {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(overallStatusMessage);
            }
        */

        static void Workflow1(string[][] userEnteredValues)
        {
            // string operationStatusMessage = "good";
            // string processStatusMessage = "";

            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    Process1(userEntries);
                    Console.WriteLine("Process1 completed successfully.");
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Process1 encountered an issue, process aborted.");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
                //     processStatusMessage = Process1(userEntries);

                //     if (processStatusMessage == "process complete")
                //     {
                //         Console.WriteLine("'Process1' completed successfully.");
                //         Console.WriteLine();
                //     }
                //     else
                //     {
                //         Console.WriteLine("'Process1' encountered an issue, process aborted.");
                //         Console.WriteLine(processStatusMessage);
                //         Console.WriteLine();
                //         operationStatusMessage = processStatusMessage;


                //     }
                // }
                // if (operationStatusMessage == "good")
                // {
                //     operationStatusMessage = "operating procedure complete";
                // }

                // return operationStatusMessage;

            }
            static void Process1(String[] userEntries)
            {
                int valueEntered;


                // string processStatus = "clean";
                // string returnMessage = "";


                foreach (string userValue in userEntries)
                {
                    bool integerFormat = int.TryParse(userValue, out valueEntered);

                    if (integerFormat == true)
                    {
                        if (valueEntered != 0)
                        {
                            checked
                            {
                                int calculatedValue = 4 / valueEntered;
                            }
                        }
                        else
                        {

                            throw new DivideByZeroException("invalid data.");
                            //             returnMessage = "Invalid data. User input values must be above 0";
                            //             processStatus = "error";
                        }
                    }
                    else
                    {
                        throw new FormatException("invalid data");
                        //         returnMessage = "Invalid data. User input values must be valid";
                        //         processStatus = "error";
                        //     }
                    }
                    // if (processStatus == "clean")
                    // {
                    //     returnMessage = "process complete";
                }
                // return returnMessage;
            }
        }




    }
}
