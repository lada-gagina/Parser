module SupportingFunctions
open Microsoft.FSharp.Text.Lexing
open AST
open ParseLiteral

let getPos (lexbuf : LexBuffer<_>) = new Position(lexbuf.StartPos.Line,
                                                  lexbuf.StartPos.Column,
                                                  lexbuf.EndPos.Line,
                                                  lexbuf.EndPos.Column - 1)


let getIntegerLiteral lexbuf = 
    new IntegerLiteral(ParseInt(LexBuffer<_>.LexemeString lexbuf), getPos lexbuf)

let getBooleanLiteral lexbuf = 
    new BooleanLiteral(ParseBool(LexBuffer<_>.LexemeString lexbuf), getPos lexbuf)

let getCharLiteral lexbuf = 
    new CharLiteral(ParseChar(LexBuffer<_>.LexemeString lexbuf), getPos lexbuf)

let getStringLiteral lexbuf = 
    new StringLiteral(ParseString(LexBuffer<_>.LexemeString lexbuf), getPos lexbuf)

let getFloatLiteral lexbuf = 
    new FloatLiteral(ParseFloat(LexBuffer<_>.LexemeString lexbuf), getPos lexbuf)

let getNullLiteral lexbuf =
    new NullLiteral(getPos lexbuf)


let getId lexbuf = 
    new ID(LexBuffer<_>.LexemeString lexbuf, getPos lexbuf)


let commonPosition (pos1 : Position) (pos2 : Position) = 
    new Position(pos1.StartPos, pos2.EndPos)


let lexemeToBinaryOperator lexbuf = 
    match LexBuffer<_>.LexemeString lexbuf with
    | "*"  -> MULTIPLICATION
    | "/"  -> DIVISION
    | "%"  -> MODULUS
    | ">"  -> GREATER
    | ">=" -> GREATER_OR_EQUAL
    | "<"  -> LESS
    | "<=" -> LESS_OR_EQUAL
    | "==" -> EQUAL
    | "!=" -> NOT_EQUAL
    | "||" -> OR
    | "&&" -> AND
    | "."  -> MEMBER_CALL
    | "+"  -> ADDITION
    | "-"  -> SUBSTRACTION
    |  _   -> failwith "incorrect binary operator!"

//let lexemeToType lexbuf =
//    match
