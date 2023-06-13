int main2() {
    std::vector<int> v = {0, 1, 2, 3, 4, 5};
    for (auto n = v.size(); auto i : v) // the init-statement (C++20)
    v.push_back(1);
    return 0;
}