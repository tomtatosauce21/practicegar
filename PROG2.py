import re


def is_valid_expression(expression):
    # Remove spaces for easier processing
    expression = expression.replace(" ", "")

    # Check for balanced parentheses
    stack = []
    for char in expression:
        if char == '(':
            stack.append(char)
        elif char == ')':
            if not stack:
                return False
            stack.pop()
    if stack:
        return False

    # Check for valid characters including variables (letters)
    pattern = r'^[a-zA-Z\d()+\-*/**]+$'  # Allow letters, digits, parentheses, and operators
    if not re.match(pattern, expression):
        return False

    # Ensure no consecutive invalid operators (except negative sign at the start)
    if re.search(r'(?<!\*)\*{3,}', expression) or re.search(r'[+\-*/]{2,}', expression):
        return False

    # Ensure expression does not start or end with an invalid operator
    if re.match(r'^[+*/]', expression) or re.match(r'[+\-*/]$', expression):
        return False

    return True


# Loop for multiple attempts
while True:
    expression = input("Enter an arithmetic expression (or 'exit' to quit): ")
    if expression.lower() == 'exit':
        print("Goodbye!")
        break
    if is_valid_expression(expression):
        print("Valid expression")
    else:
        print("Invalid expression, try again.")

