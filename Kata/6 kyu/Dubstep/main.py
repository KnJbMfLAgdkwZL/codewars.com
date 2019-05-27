# Dubstep
# https://www.codewars.com/kata/551dc350bf4e526099000ae5

def song_decoder(song):
    res = song.split('WUB')
    res = ' '.join(res).strip()
    while res.find('  ') != -1:
        res = res.replace('  ', ' ')
    return res
