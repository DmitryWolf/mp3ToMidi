import Converter

def main():
    try:
        converter = Converter.midiConverter(input_folder='input', output_folder='output', temp_folder='temp_dir', bpm=120, smooth=0.25)
    except Exception as e:
        print('Error: ', e)
    converter.process_all_files()

if __name__ == "__main__":
    main()
