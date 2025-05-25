#ifndef EXPRESSION_EVALUATOR_H
#define EXPRESSION_EVALUATOR_H

#include <stdexcept>

class ExpressionEvaluator {
private:
    double a, b, c, d;

public:
    ExpressionEvaluator();
    ExpressionEvaluator(double a, double b, double c, double d);
    void setA(double value);
    void setB(double value);
    void setC(double value);
    void setD(double value);
    double evaluate() const;
    double getValue() const;
};

#endif