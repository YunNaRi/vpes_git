void test1() {
	[]() {
		return []() {

			return []() {

			};
		};
	};

}


void test2() {
	int a = 10;
	char b = 'a';
	int cccc = 11;
	a = a + 1;
	auto f = [&](int t) {
		int c = 10;
		if (t==1) {}
		return 110;
	};
	a = 10;
	f(10);
	f(1);
}

void test3()
{
	[] {}(), [] {}();
}


int undet;
void test4() {
	int a = 10;
	char b = 'a';
	auto f = []() {
		return 110; };
	float c = 0.0;

	if (undet) {
		auto f = []() { return 10; };
	}
	else {
		auto f = []() { return 20; };
	}
}


void test5() {
	auto lambda = [&](int i)
	{
		for (int j = 0; j < 1;) {
			break;
		}
	};
	lambda(0);
}


// 코드가 복잡.. 그림 점검 필요...
int test6(int x, int y) {
	return [&](int x, int y) {
		auto a = [] { return 0; }();
		auto generic_add = [](auto a, auto b) {
			if (a == b) {
				return a * 2;
			}
			else {
				return a + b;
			}
		};

		if (x == 0) {
			return [&](int v) { return v + y; }(y);
		}
		else {
			return generic_add(x, y);
		}
	}(x, y);
}


void test7(int x) {
	auto a = [](int b) {
		auto c = [](int v) {
			double a;
			a = 11;
			return 10; };
	};
	auto ad = [](int asdk) {
		return 11111;
	};
}



int test8(int x, int y) {
	auto z = [](int a=3, int b=1) {
		if (a > b) {
			return 1;
		}
		else {
			return 0;
		}
	}();
	return y;
}


//PA6-331
int test9() {
	(([&]() { int i = 0; i++; }()));
	return 0;
}


void test10() {
	auto f1 = [](int x) {
		if (x < 10) {
		}
		else {
		}
	};

	f1(12);
}


void test11() {
	[] {int i=0; i++; }();
	int x;
	[] {int i=0; i++; }();
	return;
}

void test12() {
	[] {int j;
	int i;
	}(),
		[] {int j; }(),
		[] {if (1) {} int i; }();
}


void test13() {
	int a = 10;
	if (1) {

	}
	[] {}(),
		[] {int jj=0; jj++; }();
	auto b = []() {};
	if (1) {

	}
	[] {}(),
		[] {int j; }();
}

//데모
void test14() {
	int a;
	[] {
		[] {int j=0; j++; };
		[] {int i; };
	}();
	[] {auto a = [] {int j=0; j++; }; }(), [] {}();
}


// 체크
void test15()
{
	int a = 1;
	if (1) {}
	[] {
		[] {return 10; };
		[] {int j=0; j++; };
	}(), [] {}();
}



void test16() {
	auto a = [] {int i=0; i++; };
	int x = 0;
	if (x) {
		a();
	}
	else {
		a();
	}
	a();
}


void test17() {
	int x;
	x = []() {
		return 1;
	}();

	int y;
	auto k = []() {
		auto q = []() {
			return 0;
		};

		return q;
	};

	[]() {
		return 0;
	}();
	auto xx = k();
	xx();
}

int test18() {
	[]() { int i = 0; i++; }();
	int w;
	int w2;
	int w3;
	[]() { int i = 0; i++; }();
	[]() { int i = 0; i++; }();
	[]() { int i = 0; i++; }();
	int x;
	int y = 0;
	[]() { int i = 0; i++; }();
	if (y == 0) {
	}
	else {
		int z;
	}
	return 0;
}


void test19()
{
	[] {
		[]() {
			[]() {
				[]() {};
			};
		};
	};
}

void test20()
{
	[] {return 10; }(), [] {int j; }();
	[] {}(),
		[] {}(),
		[] {
		[]() {};
		[]() {};
	}();
}

void test21()
{
	if (1) {
		auto a = [] {return 1; }();
	}
	[] {return 10; }(), [] {return 10; }();
}

void test22()
{
	[] {return 10; }(), [] {int j = 0; j++; }();
}

void test23()
{
	[] {return 10; }(),
		[] {
		int j;
	}(),
		[] {return 10; }();
}




struct X {
	int a;
	int b;
};

int global;


int test24(X& xx) {
	auto x = [&](int q) {
		X xx;
		xx.a = 0;
		bool condition = (xx.b > 10 && q < 20) || (q > 100);
		if (condition) {
		}

		global = 10;

	};

	return 0;
}


void test25() {
	auto aaaa = []() {
		[] {return [] {
			int a; }();
		}();
	};
	[] {int i; }(), [] {return 1; }(), [] {}();
	int a = 10;
	char b = 'a';
	int cccc = 11;
	a = a + 1;
	auto f = []() {
		int c = 10;
		if (1) {}
		return 110;
	};
	a = 10;
	if ([] {return 10; }()) {
		;
	}
	else {
		b = 'B';

	}
}

void test26()
{
	if ([] {return 1; }()) {
		while ([] {return false;; }())
		{
			if ([] {if (1) { auto a = [] {}; } return 10; }()) {

			}
		}

	}
}

void test27() {
	[]() {
		[] {
			[] {int j = 0; j++; return 100; }();
		}();
		[] {return 10; }();
	};
	[]() {}, []() {int j; };
}

void test28() {
	int a = 10;
	if (1) {}

	[] {
		int j;
		[] {int i; }(),
			[] {}(),
			[] {int j; }();
	}(),
		[] {
		[]() {int i; };
	}(),
		[] {return 10; }();
	int b = 10;
}

void test29() {
	auto aaaa = []() {
		[] {return [] {
			int a; }();
		}();
	};
	[] {int i; }(), [] {return 1; }(), [] {}();
	int a = 10;
	char b = 'a';
	int cccc = 11;
	a = a + 1;
	auto f = []() {
		int c = 10;
		if (1) {}
		return 110;
	};
	a = 10;
	if ([] {return 10; }()) {
		return [] {}();
	}
	else {
		b = 'B';

	}
}



// 아래 예제는 클래스의 맴버함수 1개 test 함수 1개 총 2개로 구분됨. 람다 바디가 2개이며 나머지는 문제없음

class Person {
public:
	Person(int i, int j, int z) : num(i), num2(j), num3(z) {}
	void introduce() {
		[this]() {num = 10; }();
	}
private:
	int num;
	int num2;
	int num3;
};

int test30() {
	Person* devkoriel = new Person([] {return 10; }(), [] {return 30; }(), [] {return 1; }());
	devkoriel->introduce();

	return 0;
}


// 함수의 인자로 Lambda 사용
int f(int a, int b) {
	return a + b;
}

int test31()
{
	int aa = 100;
	f([&] {return aa; }(), [] {return 10; }());
	return 0;
}

int main()
{
	//======= 람다 서커스 시작.======
	//------------------------커버리지 오류---------------------
	auto gener_lambda1 = [](int a, int b) {

		return a < b;
	};

	for (int i = 0; i < 100; i++)
		gener_lambda1(23, 123);

	auto gener_lambda2 = [](int a, int b) {

		return ([](int a, int b) { return a < b; }); //실행안함.
	};
	gener_lambda2(23, 123);

	auto gener_lambda3 = [](int a, int b) {

		return [](int a, int b) {
			return [](int a, int b) { return a < b; }; //실행안함
		};
	};
	gener_lambda3(23, 123);

	auto gener_lambda00 = [](int a, int b) {

		return [](int a, int b) { return a < b; }; //실행안함
	};

	auto gener_lambda11 = [](int a, int b) {

		return [](int a, int b) {
			return [](int a, int b) { return a < b; };
		}; //실행안했음.
	};
	auto gener_lambda5 = [gener_lambda00, gener_lambda11](int a, int b) {
		gener_lambda00(a, b);
		gener_lambda11(a, b);
	};
	gener_lambda5(23, 123);

	test1();
	test2();
	test3();
	test4();
	test5();
	test6(1, 2);
	test7(10);
	test8(5, 10);
	test9();
	test10();
	test11();
	test12();
	test13();
	test14();
	test15();
	test16();
	test17();
	test18();
	test19();
	test20();
	test21();
	test22();
	test23();
	X obj;
	test24(obj);
	test25();
	test26();
	test27();
	test28();
	test29();
	test30();
	test31();
	
	return 0;
}