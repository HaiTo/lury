﻿//
// OutputLogger.cs
//
// Author:
//       Tomona Nanase <nanase@users.noreply.github.com>
//
// The MIT License (MIT)
//
// Copyright (c) 2014 Tomona Nanase
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
using System.Collections.Generic;
using System.Linq;

namespace Lury.Compiling.Logger
{
    public class OutputLogger
    {
        #region -- Private Fields --

        private readonly ICollection<CompileOutput> outputs;

        #endregion

        #region -- Public Properties --

        public IEnumerable<CompileOutput> Outputs { get { return this.outputs; } }

        #endregion

        #region -- Constructors --

        public OutputLogger()
        {
            this.outputs = new List<CompileOutput>();
        }

        #endregion

        #region -- Public Methods --

        public void Error(ErrorCategory number,
                          string code = null,
                          string sourceCode = null,
                          CharPosition position = default(CharPosition),
                          string appendix = null)
        {
            this.outputs.Add(new CompileOutput(OutputCategory.Error, (int)number, code, sourceCode, position, appendix));
        }

        public void Warn(WarnCategory number,
                         string code = null,
                         string sourceCode = null,
                         CharPosition position = default(CharPosition),
                         string appendix = null)
        {
            this.outputs.Add(new CompileOutput(OutputCategory.Warn, (int)number, code, sourceCode, position, appendix));
        }

        public void Info(InfoCategory number,
                         string code = null,
                         string sourceCode = null,
                         CharPosition position = default(CharPosition),
                         string appendix = null)
        {
            this.outputs.Add(new CompileOutput(OutputCategory.Info, (int)number, code, sourceCode, position, appendix));
        }

        public void Clear()
        {
            this.outputs.Clear();
        }

        #endregion
    }
}
