from Counter import Counter
from Clock import Clock

clock = Clock()
for x in range(86450):
    clock.Tick()
    print(clock.Time)