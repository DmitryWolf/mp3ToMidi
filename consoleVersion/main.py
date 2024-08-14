import Converter

def main():
    converter = Converter(input_folder='input', output_folder='output', temp_folder='temp_dir', bpm=120, smooth=0.25)
    converter.process_all_files()

if __name__ == "__main__":
    main()
