class Transcriptor {
    toRna(dna: string): string {
        return dna.split('').map(this.transcribe).join('')
    }

    transcribe(dna: string): string {
        if (dna === 'C') {
            return 'G'
        } else if (dna === 'G') {
            return 'C'
        } else if (dna === 'A') {
            return 'U'
        } else if (dna === 'T') {
            return 'A'
        }
        throw Error('Invalid input DNA.')
    }
}

export default Transcriptor