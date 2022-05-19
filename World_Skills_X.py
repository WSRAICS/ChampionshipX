import tkinter
from PIL import Image, ImageTk


class App:
    def __init__(self):
        self.root = tkinter.Tk()
        self.root.title('World Skills X')
        self.root.iconbitmap("TLgreen.ico")
        

        # создаем рабочую область
        self.frame = tkinter.Frame(self.root)
        self.frame.grid()


        self.image = Image.open("WS.png")
        self.photo = ImageTk.PhotoImage(self.image)

        # вставляем кнопку
        self.but = tkinter.Button(self.frame, text="Кнопка", command=self.my_event_handler).grid(row=1, column=2)

        # Добавим изображение
        self.canvas = tkinter.Canvas(self.root, height=1117, width=1100)
        self.c_image = self.canvas.create_image(0, 0, anchor='nw', image=self.photo)
        self.canvas.grid(row=2, column=1)
        self.root.mainloop()

    def my_event_handler(self):
        print("my_event_handler")
        self.image = Image.open("WS (1).png")
        self.photo = ImageTk.PhotoImage(self.image)
        self.c_image = self.canvas.create_image(0, 0, anchor='nw', image=self.photo)
        self.canvas.grid(row=2, column=1)


app= App()