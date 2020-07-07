#include "pch.h"
#include "ReactPackageProvider.h"

#include "NativeModules.h"
#include "Analytics.h"



using namespace winrt::Microsoft::ReactNative;

namespace winrt::DemoAppWin::implementation
{

void ReactPackageProvider::CreatePackage(IReactPackageBuilder const &packageBuilder) noexcept
{
    AddAttributedModules(packageBuilder);
}

} // namespace winrt::DemoAppWin::implementation

