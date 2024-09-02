//*****************************************************************************
//** 1894. Find the Student Who Will Replace the Chalk  leetcode             **
//*****************************************************************************


int chalkReplacer(int* chalk, int chalkSize, int k) {
    long long accSum = 0;
    
    // Calculate the accumulated sum
    for (int i = 0; i < chalkSize; ++i) {
        accSum += chalk[i];
    }

    k %= accSum;

    // Find the student who will replace the chalk
    for (int i = 0; i < chalkSize; ++i) {
        if (chalk[i] > k) {
            return i;
        }
        k -= chalk[i];
    }

    return -1;     
}