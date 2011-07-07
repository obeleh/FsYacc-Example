open System   
open Sql   
 
let x = "   
    SELECT x, y, z   
    FROM t1   
    LEFT JOIN t2   
    INNER JOIN t3 ON t3.ID = t2.ID   
    WHERE x = 50 AND y = 20   
    ORDER BY x ASC, y DESC, z   
"   
 
let lexbuf = Lexing.LexBuffer<_>.FromString x
let y = SqlParser.start SqlLexer.tokenize lexbuf   
printfn "%A" y   
 
Console.WriteLine("(press any key)")   
Console.ReadKey(true) |> ignore