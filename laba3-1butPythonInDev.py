import random
n = 0
с = 0
a = []
i = 15
while i > 0:
    a.append(random.randint(-150, 150))
    i -= 1
print(a)
for i in a:
    if i < 0:
        n+=1
    if i % 2:
        с += i
print("Кол-во отрицательный чисел:", n,"расчёта суммы чётных чисел:", с)
