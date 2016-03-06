namespace YoureBusted

module TerminalBuilder =

    open System
    open System.IO
    open YoureBusted.Types

    let createNgo name =
         { OrgName = name;
           EIN = 0;
           City = "";
           State = ""}

    let rec caller():Caller =
        printfn "Are you reporting as an advocate or survivor?" 
        let resp = Console.ReadLine().Trim().ToLower()
        match resp with
        | "advocate" -> Advocate
        | "survivor" -> Survivor
        | _ -> 
                printfn "Sorry, %A is an invalid entry" resp
                caller()

    






           
               

    
          
                         
