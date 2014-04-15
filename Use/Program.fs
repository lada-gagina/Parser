open LanguageParser
open AST

let a = ParseProgram "if (a||b) break;"
printfn "%A" a