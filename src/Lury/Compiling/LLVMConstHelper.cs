﻿//
// LLVMConstHelper.cs
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
using LLVMSharp;
using System.Runtime.InteropServices;

namespace Lury.Compiling
{
    public class LLVMConstHelper
    {
        #region -- Private Fields --

        private LLVMHelper llvmHelper;

        #region Value Constants

        private static readonly LLVMBool @false = new LLVMBool(0);
        private static readonly LLVMBool @true = new LLVMBool(1);

        #endregion

        #region Type

        private LLVMTypeRef booleanType;

        #endregion

        #endregion

        #region -- Public Properties --

        public LLVMHelper LLVMHelper { get { return this.llvmHelper; } }

        #region Value Constants

        private LLVMBool False { get { return @false; } }

        private LLVMBool True { get { return @true; } }

        #endregion

        #region Type

        private LLVMTypeRef BooleanType { get { return this.booleanType ?? (this.booleanType = LLVM.Int1TypeInContext(this.llvmHelper.Context)); } }

        #endregion

        #endregion

        #region -- Constructors --

        public LLVMConstHelper(LLVMHelper llvmHelper)
        {
            this.llvmHelper = llvmHelper;
        }

        #endregion

        #region -- Public Methods --



        #endregion
    }
}

