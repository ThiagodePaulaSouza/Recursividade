def reverterString(s):
    if len(s) <= 1:
        return s
    return reverterString(s[1:]) + s[0]

stringDeTeste = "bom dia tudo bom"
print(reverterString(stringDeTeste))