import AuthProvider from './src/context/AuthContext';
import SpinnerProvider from './src/context/SpinnerContext';
import StackNavigator from './src/navigation/StackNavigator';

export default function CinemaBookingApp() {
  return (
    <SpinnerProvider>
      <AuthProvider>
        <StackNavigator />
      </AuthProvider>
    </SpinnerProvider>
  );
}
