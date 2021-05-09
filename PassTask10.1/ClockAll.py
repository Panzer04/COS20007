class Counter:

    def __init__(self, name):
        self._count = 0
        self._name = name

    def Increment(self):
        self._count += 1

    def Reset(self):
        self._count = 0

    @property
    def Name(self):
        return self._name
    
    @Name.setter
    def Name(self, value):
        self._name = value

    @property 
    def Ticks(self):
        return self._count


class Clock:
    def __init__(self):
        self._seconds = Counter("seconds")
        self._minutes = Counter("minutes")
        self._hours = Counter("hours")


    
    def Tick(self):
        self._seconds.Increment()
        if self._seconds.Ticks > 59:
            self._minutes.Increment()
            self._seconds.Reset()
            if self._minutes.Ticks > 59:
                self._hours.Increment()
                self._minutes.Reset()
                if self._hours.Ticks > 23:
                    self.Reset()

    def Reset(self):
        self._seconds.Reset()
        self._minutes.Reset()
        self._hours.Reset()

    @property
    def Time(self):
        return str(self._hours.Ticks).zfill(2) + ":" + str(self._minutes.Ticks).zfill(2) + ":" + str(self._seconds.Ticks).zfill(2)

clock = Clock()
for x in range(86450):
    clock.Tick()
    print(clock.Time)