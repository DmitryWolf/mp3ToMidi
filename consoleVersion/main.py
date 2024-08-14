import shutil
import os
import ffmpeg
import audio_to_midi_melodia as audio

class midiConverter:
    def __init__(self, input_folder, output_folder, temp_folder, bpm=120, smooth=0.25, minduration=0.1, savejams=False):
        """
        Инициализация класса с указанием путей к папкам и параметров для конвертации.

        :param input_folder: Путь к папке с входными WAV файлами
        :param output_folder: Путь к папке для сохранения MIDI файлов
        :param temp_folder: Путь к папке для сохранения WAV после конвертации из MP3
        :param bpm: Темп мелодии в ударах в минуту (по умолчанию 120)
        :param smooth: Параметр сглаживания частоты мелодии
        :param minduration: Минимальная продолжительность мелодии
        :param savejams: Сохранять ли JAMS файлы (по умолчанию False)
        """
        script_dir = os.path.dirname(os.path.abspath(__file__))
        
        self.input_folder = os.path.join(script_dir, input_folder)
        self.output_folder = os.path.join(script_dir, output_folder)
        self.temp_folder = os.path.join(script_dir, temp_folder)

        self.bpm = bpm
        self.smooth = smooth
        self.minduration = minduration
        self.savejams = savejams

        os.makedirs(self.output_folder, exist_ok=True)

    def __del__(self):
        if os.path.exists(self.temp_folder):
            shutil.rmtree(self.temp_folder)

    def convert_mp3_to_wav(self, mp3_file):
        """
        Конвертирует один MP3 файл в WAV файл

        :return: Путь к файлу WAV во временной папке
        """
        os.makedirs(self.temp_folder, exist_ok=True)

        wav_file = os.path.join(self.temp_folder, os.path.splitext(os.path.basename(mp3_file))[0] + '.wav')

        ffmpeg.input(mp3_file).output(wav_file).run()
        
        return wav_file
    
    def convert_wav_to_midi(self, input_file):
        """
        Конвертирует мелодию из одного WAV файла в MIDI

        :param input_file: Путь к файлу WAV
        :return: None
        """
        midi_filename = os.path.splitext(os.path.basename(input_file))[0] + '.mid'
        output_file = os.path.join(self.output_folder, midi_filename)
        audio.audio_to_midi_melodia(input_file, output_file, bpm=self.bpm,
                                    smooth=self.smooth, minduration=self.minduration,
                                    savejams=self.savejams)
        print(f"The conversion is completed: {input_file} -> {output_file}")
    
    def process_all_files(self):
        """
        Обрабатывает все аудиофайлы (WAV и MP3) в папке input_folder и сохраняет результат в output_folder
        """
        for filename in os.listdir(self.input_folder):
            input_file = os.path.join(self.input_folder, filename)

            if filename.endswith('.wav'):
                self.convert_wav_to_midi(input_file)
            elif filename.endswith('.mp3'):
                wav_file = self.convert_mp3_to_wav(input_file)
                self.convert_wav_to_midi(wav_file)
            else:
                print(f"Missing file (not supported): {filename}")

def main():
    converter = midiConverter(input_folder='input', output_folder='output', temp_folder='temp_dir', bpm=120, smooth=0.25)
    converter.process_all_files()

if __name__ == "__main__":
    main()