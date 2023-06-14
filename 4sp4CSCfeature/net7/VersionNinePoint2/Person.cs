using System.Diagnostics.CodeAnalysis;


namespace ConsoleApp3.VersionNinePoint2
{
    class Person
    {
        public Person() { }

        [SetsRequiredMembers]
        public Person(string firstName)
        {
            FirstName = firstName;
        }

        public required string FirstName { get; init; }

        // Omitted for brevity.
    }
}