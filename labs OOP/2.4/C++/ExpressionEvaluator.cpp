#include "ExpressionEvaluator.h"
#include <cmath>

ExpressionEvaluator::ExpressionEvaluator() : a(0.0), b(1.0), c(0.0), d(0.0) {}

ExpressionEvaluator::ExpressionEvaluator(double a, double b, double c, double d) {
    setA(a);
    setB(b);
    setC(c);
    setD(d);
}

void ExpressionEvaluator::setA(double value) {
    a = value;
}

void ExpressionEvaluator::setB(double value) {
    if (value == 0.0) {
        throw std::runtime_error("Division by zero: b cannot be zero");
    }
    b = value;
}

void ExpressionEvaluator::setC(double value) {
    c = value;
}

void ExpressionEvaluator::setD(double value) {
    d = value;
}

double ExpressionEvaluator::evaluate() const {
    double numerator = 1.0 + a - (b / 2.0);
    double innerSqrt = 24.0 + d - c;
    if (innerSqrt < 0.0) {
        throw std::domain_error("Square root argument cannot be negative");
    }
    double denominator = std::sqrt(innerSqrt) + (a / b);
    if (denominator == 0.0) {
        throw std::overflow_error("Denominator cannot be zero");
    }
    return numerator / denominator;
}

double ExpressionEvaluator::getValue() const {
    return evaluate();
}