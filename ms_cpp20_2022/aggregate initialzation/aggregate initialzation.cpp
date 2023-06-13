struct C
{
    union
    {
        int a;
        const char* p;
    };

    int x;
} c = { .a = 1, .x = 3 }; // initializes c.a with 1 and c.x with 3

struct A
{
    int x;

    struct B
    {
        int i;
        int j;
    } b;
} a = { 1, {2, 3} }; // initializes a.x with 1, a.b.i with 2, a.b.j with 3

struct base1 { int b1, b2 = 42; };

struct base2
{
    base2()
    {
        b3 = 42;
    }

    int b3;
};

struct derived : base1, base2
{
    int d;
};

derived d1{ {1, 2}, {}, 4 }; // initializes d1.b1 with 1, d1.b2 with 2,
                           //             d1.b3 with 42, d1.d with 4
derived d2{ {}, {}, 4 };     // initializes d2.b1 with 0, d2.b2 with 42,
                           //             d2.b3 with 42, d2.d with 4