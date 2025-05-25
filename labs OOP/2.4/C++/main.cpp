#include "ExpressionEvaluator.h"
#include <iostream>
#include <vector>

int main() {
    std::vector<ExpressionEvaluator> evaluators;
    evaluators.reserve(3);


    try {
        evaluators.emplace_back(1.0, 2.0, 3.0, 4.0);
    }
    catch (const std::exception& e) {
        std::cout << "Construction error for object 1: " << e.what() << std::endl;
    }

    try {
        evaluators.emplace_back(5.0, 0.0, 6.0, 7.0);
    }
    catch (const std::exception& e) {
        std::cout << "Construction error for object 2: " << e.what() << std::endl;
    }

    try {
        evaluators.emplace_back(8.0, 4.0, 9.0, 10.0);
    }
    catch (const std::exception& e) {
        std::cout << "Construction error for object 3: " << e.what() << std::endl;
    }

    std::vector<double> results;
    results.reserve(evaluators.size());


    for (size_t i = 0; i < evaluators.size(); ++i) {
        try {
            double result = evaluators[i].evaluate();
            results.push_back(result);
            std::cout << "Result for object " << i << ": " << result << std::endl;
        }
        catch (const std::runtime_error& e) {
            std::cout << "Runtime error for object " << i << ": " << e.what() << std::endl;
        }
        catch (const std::domain_error& e) {
            std::cout << "Domain error for object " << i << ": " << e.what() << std::endl;
        }
        catch (const std::overflow_error& e) {
            std::cout << "Overflow error for object " << i << ": " << e.what() << std::endl;
        }
        catch (const std::exception& e) {
            std::cout << "Unexpected error for object " << i << ": " << e.what() << std::endl;
        }
    }

    std::cout << "\nAll results: ";
    for (size_t i = 0; i < results.size(); ++i) {
        std::cout << results[i] << (i < results.size() - 1 ? ", " : "\n");
    }

    return 0;
}