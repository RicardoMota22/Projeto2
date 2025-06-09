using System;

namespace LibrarySim.Model
{
    public interface IBook : IEquatable<IBook>, IComparable<IBook>
    {
        string Title { get; }
        string Author { get; }
        int Year { get; }
        bool IsBorrowed { get; }
        void Borrow();
        void ReturnBook();
    }
}

