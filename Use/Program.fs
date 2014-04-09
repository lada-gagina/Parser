open LanguageParser
open AST

let a = ParseProgram "3!=(3<=a+-(b-c))"
printfn "%A" a