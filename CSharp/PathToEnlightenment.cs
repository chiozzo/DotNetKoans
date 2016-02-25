namespace DotNetKoans.CSharp
{
    public class PathToEnlightenment : KoanHelpers.IAmThePathToEnlightenment
    {
        public string[] ThePath
        {
            get
            {
                return new string[] {
				"DotNetKoans.CSharp.AboutAsserts", // DONE
				"DotNetKoans.CSharp.AboutNil", // DONE
				"DotNetKoans.CSharp.AboutArrays", // DONE
				"DotNetKoans.CSharp.AboutArrayAssignment", // DONE
				"DotNetKoans.CSharp.AboutStrings", // DONE
				"DotNetKoans.CSharp.AboutInheritance", // DONE
				"DotNetKoans.CSharp.AboutMethods", // IN PROGRESS
				"DotNetKoans.CSharp.AboutControlStatements",
				"DotNetKoans.CSharp.AboutGenericContainers",
				"DotNetKoans.CSharp.AboutDelegates",
				"DotNetKoans.CSharp.AboutLambdas"
                };
            }
        }
    }
}
