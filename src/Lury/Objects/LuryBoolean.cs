﻿//
// LuryBoolean.cs
//
// Author:
//       Tomona Nanase <nanase@users.noreply.github.com>
//
// The MIT License (MIT)
//
// Copyright (c) 2015 Tomona Nanase
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Lury.Runtime;

namespace Lury.Objects
{
    public class LuryBoolean : LuryObject
    {
        public static readonly LuryBoolean True = new LuryBoolean(true);
        public static readonly LuryBoolean False = new LuryBoolean(false);

        private readonly bool value;

        public bool Value　{ get { return this.value; } }

        private LuryBoolean(bool value)
        {
            this.value = value;
        }

        public override LuryBoolean LNot()
        {
            return this.value ? False : True;
        }

        public override LuryBoolean LAnd(LuryObject other)
        {
            if (other == null)
                throw new LuryException(LuryExceptionType.NilReference);

            if (!(other is LuryBoolean))
                throw new LuryException(LuryExceptionType.NotSupportedOperationBinary);

            return this.value && ((LuryBoolean)other).value ? True : False;
        }

        public override LuryBoolean LOr(LuryObject other)
        {
            if (other == null)
                throw new LuryException(LuryExceptionType.NilReference);

            if (!(other is LuryBoolean))
                throw new LuryException(LuryExceptionType.NotSupportedOperationBinary);

            return this.value || ((LuryBoolean)other).value ? True : False;
        }

        public override LuryBoolean CEq(LuryObject other)
        {
            if (other == null)
                throw new LuryException(LuryExceptionType.NilReference);

            if (!(other is LuryBoolean))
                throw new LuryException(LuryExceptionType.NotSupportedOperationBinary);

            return this.value == ((LuryBoolean)other).value ? True : False;
        }

        public override string ToString()
        {
            return this.value ? "true" : "false";
        }
    }
}

