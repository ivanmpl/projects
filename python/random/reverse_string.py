
def reverse_string_v1(str):
    """ Function to reverse a string using slice syntax """
    str = str[::-1]
    return str


def reverse_string_v2(str):
    """ Function to reverse a string using a for loop"""
    rev = ""
    for i in str:
        rev = i + rev
    return rev


# TODO: expand on time and space complexity also alternative versions

str = "goodbye"

print(f"The original string: {str}")
print(f"The reversed string(v1): {reverse_string_v1(str)}")
print(f"The reversed string(v2): {reverse_string_v2(str)}")
