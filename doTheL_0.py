def generate_L():
    width = 10
    height = 20
    l_pixels = [[0 for _ in range(width)] for _ in range(height)]
    for i in range(height):
        l_pixels[i][0] = 1
    for j in range(width):
        l_pixels[height - 1][j] = 1

    l_string = ""
    for row in l_pixels:
        for pixel in row:
            if pixel == 1:
                l_string += "L"
            else:
                l_string += " "
        l_string += "\n"

    return l_string

print(generate_L())