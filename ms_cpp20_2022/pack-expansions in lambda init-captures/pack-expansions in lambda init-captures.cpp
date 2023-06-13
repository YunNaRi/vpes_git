template<class... Args>
void f(Args... args)
{
    auto lm = [&, args...]{ return g(args...); };
    lm();
}