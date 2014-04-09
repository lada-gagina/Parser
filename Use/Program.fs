open LanguageParser
open AST

let a = ParseProgram "{1 && 2 || 6 || instanceOf1 + 3 instanceOf instanceOf2[][][], {null,{}}}"
printfn "%A" a