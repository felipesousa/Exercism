class Pangram {
    str: string[]

    constructor( str: string ) {
        this.str = str.toLowerCase().split('')
    }

    isPangram(): boolean {
        this.str.
        return false
    }

    getAlphabet(): string[] {
        const ret = new Array<string>()
        for (let i = 0; i < 26; i++) {
            ret.push('a' + i)
        }
        return ret
    }
}

export default Pangram
