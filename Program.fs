open System
open System.IO
open System.Collections.Generic
open System.Data
open System.Data.SqlClient
open System.Linq
open YoureBusted.Types
open YoureBusted.TerminalBuilder


[<EntryPoint>]
let main argv = 
    printfn "Welcome to the You're Busted App" 
    let c = (caller())
    0 // return an integer exit code

