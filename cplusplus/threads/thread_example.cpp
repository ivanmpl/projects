#include <iostream>
#include <thread>

// sample function called by thread
void sampleThread() {
    std::cout << "In Thread" << std::endl;
}

int main() {
    std::cout << "In Main" << std::endl;
    // Construct thread (calls sampleThread from new thread)
    std::thread aThread(sampleThread);
    // Join with athread; main thread will wait for aThread to finish
    aThread.join();
    // Construct thread (calls secondThread from new thread)
    std::thread bThread([] (){
        std::cout << "In Lambda" << std::endl;        
    });
    
    bThread.join();
        
    std::cout << "Done" << std::endl;
    return 0;
}