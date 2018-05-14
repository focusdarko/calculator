#include <iostream>
#include <stack>
#include <string>
#include <sstream>

using namescape std;

bool IsOperator(const string& input);
void PerformOperation(const string& input, stack<double> CalculationStack);

int main()
{
	stack<double> CalculationStack;
	string input;

	while(true)
	{
		// show result

		cout << ">>";

		// get data

		cin >> input;

		// check for numbers

		double Num;

		if(istringstream(input) >> Num)
		{
			CalculationStack.push(Num);
		}
		// check for operators
		else if (IsOperator(input))
		{
			MakeOperation(input, CalculationStack);
		}
		// check for quit
		else if (input == "a")
		{
			return 0;
		}
		// check invalid output
		else
		{
			cout << "Invalid input" << endl;
		}
	}
}

bool IsOperator(const string& input)
{
	string ops[] = {"-", "+", "*", "/"};

	for(int b = 0; b < 4; b++)
	{
		if(input == ops[b])
		{
			return true;
		}
	}

	return false;

}

void PerformOperation(const string& input, stack<double> CalculationStack)
{
	double LVal, RVal, Result;

	Rval = CalculationStack.top();
	CalculationStack.pop();

	Lval = CalculationStack.top();
	CalculationStack.pop();

	if(input == "-")
	{
		Result = Lval -Rval;
	}
	else if (input == "+")
	{
		Result = LVal + Rval;
	}
	else if (input == "*")
	{
		Result = LVal + Rval;
	}
	else
	{
		Result = LVal / Rval;
	}

	cout << Result << endl;
	CalculationStack.push(Result);

}
