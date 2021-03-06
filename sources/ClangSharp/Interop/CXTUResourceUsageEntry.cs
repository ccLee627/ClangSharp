// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-9.0.0/clang/include/clang-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

#if Windows_NT
using nulong = System.UInt32;
#else
using System;
using nulong = System.UIntPtr;
#endif

namespace ClangSharp.Interop
{
    public partial struct CXTUResourceUsageEntry
    {
        [NativeTypeName("enum CXTUResourceUsageKind")]
        public CXTUResourceUsageKind kind;

        [NativeTypeName("unsigned long")]
        public nulong amount;
    }
}
