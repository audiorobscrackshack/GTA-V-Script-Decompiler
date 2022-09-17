﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decompiler.Ast
{
    internal class IntegerEq : AstToken
    {
        AstToken Lhs;
        AstToken Rhs;
        public IntegerEq(Function func, AstToken lhs, AstToken rhs) : base(func)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public override Stack.DataType GetType()
        {
            return Stack.DataType.Bool;
        }

        public override string ToString()
        {
            return Lhs + " == " + Rhs;
        }
    }

    internal class IntegerNe : AstToken
    {
        AstToken Lhs;
        AstToken Rhs;
        public IntegerNe(Function func, AstToken lhs, AstToken rhs) : base(func)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public override Stack.DataType GetType()
        {
            return Stack.DataType.Bool;
        }

        public override string ToString()
        {
            return Lhs + " != " + Rhs;
        }
    }

    internal class IntegerLt : AstToken
    {
        AstToken Lhs;
        AstToken Rhs;
        public IntegerLt(Function func, AstToken lhs, AstToken rhs) : base(func)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public override Stack.DataType GetType()
        {
            return Stack.DataType.Bool;
        }

        public override string ToString()
        {
            return Lhs + " < " + Rhs;
        }
    }

    internal class IntegerLe : AstToken
    {
        AstToken Lhs;
        AstToken Rhs;
        public IntegerLe(Function func, AstToken lhs, AstToken rhs) : base(func)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public override Stack.DataType GetType()
        {
            return Stack.DataType.Bool;
        }

        public override string ToString()
        {
            return Lhs + " <= " + Rhs;
        }
    }

    internal class IntegerGt : AstToken
    {
        AstToken Lhs;
        AstToken Rhs;
        public IntegerGt(Function func, AstToken lhs, AstToken rhs) : base(func)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public override Stack.DataType GetType()
        {
            return Stack.DataType.Bool;
        }

        public override string ToString()
        {
            return Lhs + " > " + Rhs;
        }
    }

    internal class IntegerGe : AstToken
    {
        AstToken Lhs;
        AstToken Rhs;
        public IntegerGe(Function func, AstToken lhs, AstToken rhs) : base(func)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public override Stack.DataType GetType()
        {
            return Stack.DataType.Bool;
        }

        public override string ToString()
        {
            return Lhs + " > " + Rhs;
        }
    }
}