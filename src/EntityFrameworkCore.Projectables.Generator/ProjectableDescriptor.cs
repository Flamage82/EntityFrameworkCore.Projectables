﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Projectables.Generator
{
    public class ProjectableDescriptor
    {
        public string? ClassNamespace { get; set; }

        public IEnumerable<string>? NestedInClassNames { get; set; }

        public string? TargetClassNamespace { get; set; }

        public IEnumerable<string>? TargetNestedInClassNames { get; set; }

        public string? ClassName { get; set; }

        public TypeParameterListSyntax? ClassTypeParameterList { get; set; }

        public SyntaxList<TypeParameterConstraintClauseSyntax>? ClassConstraintClauses { get; set; }

        public string? MemberName { get; set; }

        public string? ReturnTypeName { get; set; }

        public ParameterListSyntax? ParametersList { get; set; }

        public TypeParameterListSyntax? TypeParameterList { get; set; }
        
        public SyntaxList<TypeParameterConstraintClauseSyntax>? ConstraintClauses { get; set; }

        public ExpressionSyntax? ExpressionBody { get; set; }
    }
}
