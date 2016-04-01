using System;
using AsmJit.Common.Operands;
using AsmJit.CompilerContext.CodeTree;

namespace AsmJit.CompilerContext
{
	internal sealed class SArgData
	{
		public static readonly long[] SArgConvTable =
		{
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (1 << 20) | (1 << 21) | (0 << 22) | (1 << 23) | (1 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (0 << 20) | (1 << 21) | (0 << 22) | (0 << 23) | (1 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (1 << 20) | (0 << 21) | (0 << 22) | (1 << 23) | (0 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (0 << 20) | (0 << 21) | (0 << 22) | (0 << 23) | (0 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (0 << 20) | (0 << 21) | (0 << 22) | (0 << 23) | (0 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (0 << 20) | (0 << 21) | (0 << 22) | (0 << 23) | (0 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (0 << 20) | (1 << 21) | (0 << 22) | (0 << 23) | (1 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (0 << 20) | (1 << 21) | (0 << 22) | (0 << 23) | (1 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (1 << 20) | (0 << 21) | (0 << 22) | (1 << 23) | (0 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (1 << 20) | (0 << 21) | (0 << 22) | (1 << 23) | (0 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (0 << 20) | (0 << 21) | (0 << 22) | (0 << 23) | (0 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (0 << 20) | (1 << 21) | (0 << 22) | (0 << 23) | (1 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (1 << 20) | (0 << 21) | (0 << 22) | (1 << 23) | (0 << 24),
			(0 << 0) | (0 << 1) | (0 << 2) | (0 << 3) | (0 << 4) | (0 << 5) | (0 << 6) | (0 << 7) | (0 << 8) | (0 << 9) | (0 << 10) | (0 << 11) | (0 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (0 << 20) | (0 << 21) | (0 << 22) | (0 << 23) | (0 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (0 << 13) | (0 << 14) | (0 << 15) | (0 << 16) | (1 << 17) | (1 << 18) | (0 << 19) | (0 << 20) | (1 << 21) | (0 << 22) | (0 << 23) | (1 << 24),
			(1 << 0) | (1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (0 << 13) | (0 << 14) | (1 << 15) | (1 << 16) | (0 << 17) | (0 << 18) | (0 << 19) | (1 << 20) | (0 << 21) | (0 << 22) | (1 << 23) | (0 << 24)
		};

		public VariableData Svd { get; set; }

		public VariableData Cvd { get; set; }

		public CallArgumentNode Arg { get; set; }

		public VariableType Type { get; set; }

		public static bool MustConvertSArg(VariableType aType, VariableType sType)
		{
			return (SArgConvTable[(int)aType] & (1 << (int)sType)) != 0;
		}

		public static VariableType TypeOfConvertedSArg(VariableType aType, VariableType sType)
		{
			if (!MustConvertSArg(aType, sType))
			{
				throw new ArgumentException();
			}

			if (aType >= VariableType.Int8 && aType <= VariableType.UIntPtr)
			{
				return aType;
			}

			switch (aType)
			{
				case VariableType.Fp32:
					return VariableType.XmmSs;
				case VariableType.Fp64:
					return VariableType.XmmSd;
			}

			return aType;
		}
	}
}