﻿namespace AST

type Statement =
    interface 
    end

type Block(statements : Statement list) =
    interface Statement
    member x.Statements = statements

type DeclarationStatement(declarationType : Type, name : string, body : Initializer) =
    interface Statement
    member x.Type = declarationType
    member x.Name = name
    member x.Body = body

type AssignmentStatement(path : string list, body : Initializer) =
    interface Statement
    member x.Path = path
    member x.Body = body

type MemberCallStatement(body : Expression) =
    interface Statement
    member x.Body = body
    
type IfStatement(condition : Expression, trueStatement : Statement, falseStatement : Statement option) =
    interface Statement
    member x.Condition      = condition
    member x.TrueStatement  = trueStatement
    member x.FalseStatement = falseStatement

type WhileStatement(condition : Expression, body : Statement) =
    interface Statement
    member x.Condition = condition
    member x.Body      = body

type ForStatement(init : DeclarationStatement list, condition : Expression option, update : AssignmentStatement list, body : Statement) =
    interface Statement
    member x.Init      = init
    member x.Condition = condition
    member x.Update    = update
    member x.Body      = body

type BreakStatement() =
    interface Statement

type ContinueStatement() =
    interface Statement

type ReturnStatement(expression : Expression option) =
    interface Statement
    member x.Expression = expression

type SuperStatement(arguments : Expression list) =
    interface Statement
    member x.Arguments = arguments
