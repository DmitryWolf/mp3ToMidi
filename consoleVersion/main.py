import Converter

def main():
    converter = Converter.midiConverter(input_folder='input', output_folder='output', temp_folder='temp_dir', bpm=120, smooth=0.25)
    try:
        converter.process_all_files()
    except Exception as e:
        print('Error: ', e)

if __name__ == "__main__":
    main()
