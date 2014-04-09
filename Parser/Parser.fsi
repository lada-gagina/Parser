// Signature file for parser generated by fsyacc
module Parser
type token = 
  | PLUS
  | DOT
  | END
  | O_SQR_BRACKET of (AST.Position)
  | C_SQR_BRACKET of (AST.Position)
  | O_BRACKET of (AST.Position)
  | C_BRACKET of (AST.Position)
  | COMMA of (AST.Position)
  | NEW of (AST.Position)
  | EXCL_MARK of (AST.Position)
  | HYPHEN of (AST.Position)
  | FACTOR of (AST.BinaryOperator)
  | COMPARE of (AST.BinaryOperator)
  | LOGICAL of (AST.BinaryOperator)
  | NULL of (AST.NullLiteral)
  | CHAR of (AST.CharLiteral)
  | BOOLEAN of (AST.BooleanLiteral)
  | FLOAT of (AST.FloatLiteral)
  | INT of (AST.IntegerLiteral)
  | STRING of (AST.StringLiteral)
  | IDENT of (AST.ID)
type tokenId = 
    | TOKEN_PLUS
    | TOKEN_DOT
    | TOKEN_END
    | TOKEN_O_SQR_BRACKET
    | TOKEN_C_SQR_BRACKET
    | TOKEN_O_BRACKET
    | TOKEN_C_BRACKET
    | TOKEN_COMMA
    | TOKEN_NEW
    | TOKEN_EXCL_MARK
    | TOKEN_HYPHEN
    | TOKEN_FACTOR
    | TOKEN_COMPARE
    | TOKEN_LOGICAL
    | TOKEN_NULL
    | TOKEN_CHAR
    | TOKEN_BOOLEAN
    | TOKEN_FLOAT
    | TOKEN_INT
    | TOKEN_STRING
    | TOKEN_IDENT
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_Expression
    | NONTERM_ExprCompareOp
    | NONTERM_ExprTermRest
    | NONTERM_ExprAddOrSubOp
    | NONTERM_ExprTermOp
    | NONTERM_ExprFactorRest
    | NONTERM_ExprFactorOp
    | NONTERM_ExprUnaryOp
    | NONTERM_IdOrMember
    | NONTERM_ExprMemberCallRest
    | NONTERM_ExprMemberCall
    | NONTERM_PrimaryExpr
    | NONTERM_Primary
    | NONTERM_Identifier
    | NONTERM_Constructor
    | NONTERM_Member
    | NONTERM_Suffix
    | NONTERM_ArrayElement
    | NONTERM_Arguments
    | NONTERM_ArgsRest
    | NONTERM_Literal
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (AST.Expression) 
