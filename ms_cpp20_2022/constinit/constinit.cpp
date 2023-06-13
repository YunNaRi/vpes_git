const char *g() { return "dynamic initialization"; }
constexpr const char *f(bool p) { return p ? "constant initializer" : g(); }

constinit const char *c = f(true); // OK
// constinit const char *d = f(false); // error

extern thread_local constinit int x;
int f() { return x; } // no check of a guard variable needed