import audio_melodia as audio
orig = raw_input()
lst = list(orig)
for i in range(3):
    lst.pop(len(orig) - 1 - i)
new = ""
for i in range(len(orig)-3):
    new = new + lst[i]
new = new + 'mid'
audio.audio_to_midi_melodia(orig, new, 88)