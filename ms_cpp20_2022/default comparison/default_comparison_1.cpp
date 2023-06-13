#include <compare>
#include <iostream>
#include <set>

template<class T1, class T2>
struct P {
    T1 x1;
    T2 x2;
    friend auto operator<=>(const P&, const P&) = default;
};

struct Point {
    int x;
    int y;
    auto operator<=>(const Point&) const = default;
    // ... non-comparison functions ...
};
// compiler generates all six two-way comparison operators

int main() {
    Point pt1{ 1, 1 }, pt2{ 1, 2 };
    std::set<Point> s; // ok
    s.insert(pt1);     // ok
    std::cout << std::boolalpha
        << (pt1 == pt2) << ' ' // false; operator== is implicitly defaulted.
        << (pt1 != pt2) << ' ' // true
        << (pt1 < pt2) << ' ' // true
        << (pt1 <= pt2) << ' ' // true
        << (pt1 > pt2) << ' ' // false
        << (pt1 >= pt2) << ' ';// false
}